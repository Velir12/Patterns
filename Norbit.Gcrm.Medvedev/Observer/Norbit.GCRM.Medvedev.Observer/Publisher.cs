using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.Observer
{
    /// <summary>
    /// Автор канала.
    /// </summary>
    public class Author
    {
        #region Свойства

        /// <summary>
        /// Видео канала.
        /// </summary>
        public Video video;

        /// <summary>
        /// Список подписчиков канала.
        /// </summary>
        protected List<Subcriber> _subscribers = new List<Subcriber>();

        #endregion

        /// <summary>
        /// Полписка на канал.
        /// </summary>
        /// <param name="subscriber"> Подписчик, который подписался.</param>
        public void Subscribe(Subcriber subscriber)
        {
            _subscribers.Add(subscriber);
        }


        /// <summary>
        /// Отписка от канала.
        /// </summary>
        /// <param name="subscriber">Подписчик, который отписался</param>
        public void Unsubscribe(Subcriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        /// <summary>
        /// Отправка уведомления.
        /// </summary>
        public void SendnNotification()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(this);
            }
        }

        /// <summary>
        /// Создание нового видео.
        /// </summary>
        /// <param name="title"> Название.</param>
        /// <param name="time"> Длительность видео.</param>
        public void PublisVideo(string title, int time)
        {
            video = new Video(title, time);
            SendnNotification();
        }
    }

    #region Классы каналов.
    /// <summary>
    /// Научный канал.
    /// </summary>
    public class ScientificChannel : Author
    {
        
    }

    /// <summary>
    /// Игровой канал.
    /// </summary>
    public class GameChannel : Author
    {

    }

    #endregion 

    /// <summary>
    /// Видео.
    /// </summary>
    public class Video
    {
        #region Свойства.

        /// <summary>
        /// Название видео.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Длительность видео.
        /// </summary>
        public int ViewingTime { get; set; }

        #endregion

        /// <summary>
        /// Контструктор.
        /// </summary>
        /// <param name="title"> Название видео.</param>
        /// <param name="time"> Длительность видео.</param>
        public Video(string title, int time)
        {
            Title = title;
            ViewingTime = time;
        }
    }


}
