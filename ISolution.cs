using System.Drawing;

namespace lab2_project
{
    /// <summary>
    /// Интерфейс для решения заданий лабораторной работы
    /// </summary>
    public interface ISolution
    {
        /// <summary>
        /// Название задания
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Описание задания
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Выполнить обработку изображения
        /// </summary>
        /// <param name="source">Исходное изображение</param>
        void Execute(Bitmap source);

        /// <summary>
        /// Получить результирующие изображения для отображения
        /// </summary>
        /// <returns>Массив пар (название, изображение)</returns>
        (string title, Bitmap image)[] GetResultImages();

        /// <summary>
        /// Получить гистограммы для отображения
        /// </summary>
        /// <returns>Массив пар (название, данные гистограммы)</returns>
        (string title, int[] histogram, Color color)[] GetHistograms();

        /// <summary>
        /// Очистка ресурсов
        /// </summary>
        void Cleanup();
    }
}
