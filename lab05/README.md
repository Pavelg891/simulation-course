### Моделирование случайных событий (GUI)

**Часть 1:**  
Приложение «Скажи “да” или “нет”».

**Часть 2:**  
Приложение «Шар предсказаний» (Magic 8-Ball).

### Приложение «Скажи “да” или “нет”».

Приложение предоставляет возможность задать вопрос и получить ответ "Да" или "Нет" с заданной вероятностью.

```
bool YesNo(double p)
{
    double value = rnd.NextDouble();
    if (value < p)
        return true;
    return false;
}
private void buttonAnswer_Click(object sender, EventArgs e)
{
    double p = 0.7;
    if (YesNo(p)) labelYesNo.Text = "Да";
    else labelYesNo.Text = "Нет";
}
```
Здесь ответ "Да" имеет вероятность 0.7, а "Нет" - 0.3.
### Приложение «Шар предсказаний» (Magic 8-Ball).
Приложение случайным образом выбирает один из набора ответов.
```
int Magic8Ball()
{
    double A = rnd.NextDouble();
    for (int k = 0; k < Answers.Length; k++)
    {
        A = A - probabilities[k];
        if (A <= 0) return k;
    }
    return -1;
}
private void buttonMagic8Ball_Click(object sender, EventArgs e)
{
    int k = Magic8Ball();
    if (k != -1) labelMagic8Ball.Text = Answers[k];
}
```
Ответы образуют полную группу попарно несовместных событий. Каждый из них имеет вероятность 1/(количество ответов).

### Эмпирическая вероятность
В программе предусмотрена возможность вывода значений эмпирических вероятностей каждого события по формуле p^k = nk/N, где nk - частота появлений k-го события, N - объем выборки.
```
private void buttonStats_Click(object sender, EventArgs e)
{
    int N = 10000;

    int[] statistics = new int[Answers.Length];

    for (int i = 0; i < statistics.Length; i++)
        statistics[i] = 0;

    for (int n = 0; n < N; n++)
    {
        int k = Magic8Ball();
        if (k != -1)
            statistics[k]++;
    }

    StringBuilder sb = new StringBuilder();
    sb.AppendLine($"N = {N}");
    sb.AppendLine();
    for (int i = 0; i < Answers.Length; i++)
    {
        double freq = (double)statistics[i] / N;
        sb.AppendLine($"{Answers[i]}: {freq:F4}");
    }
    labelStats.Text = sb.ToString();
}
```
| Ответ | Вероятность |
|-------|-------------|
| Да | 0.0689 |
| Определённо да | 0.0687 |
| Без сомнений | 0.0709 |
| Можешь быть уверен | 0.0700 |
| Скорее всего | 0.0684 |
| Нет | 0.0703 |
| Маловероятно | 0.0749 |
| Не думаю | 0.0741 |
| Определённо нет | 0.0765 |
| Очень сомнительно | 0.0726 |
| Спроси позже | 0.0706 |
| Сейчас нельзя сказать | 0.0735 |
| Ответ неясен | 0.0703 |
| Сконцентрируйся и спроси снова | 0.0703 |
