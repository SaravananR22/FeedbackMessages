﻿using System;
using System.Web.UI;

namespace FeedbackMessages
{
    /// <summary>
    /// The message that feedback to web client, users. Message object wrapper. 
    /// </summary>
    [Serializable]
    public class FeedbackMessage
    {

        /// <summary>
        /// Message levels.
        /// </summary>
        public enum FeedbackMessageLevel
        {
            /// <summary>
            /// Information level
            /// </summary>
            INFO,

            /// <summary>
            /// Success level
            /// </summary>
            SUCCESS,

            /// <summary>
            /// Warning level
            /// </summary>
            WARN,

            /// <summary>
            /// Error level
            /// </summary>
            ERROR
        }

        /// <summary>
        /// Creates information feedback message.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="reporter"></param>
        /// <returns></returns>
        public static FeedbackMessage Info(Object message, Control reporter = null)
        {
            return new FeedbackMessage()
            {
                Level = FeedbackMessageLevel.INFO,
                Message = message,
                Reporter = reporter
            };
        }

        /// <summary>
        /// Creates success feedback message.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="reporter"></param>
        /// <returns></returns>
        public static FeedbackMessage Success(Object message, Control reporter = null)
        {
            return new FeedbackMessage()
            {
                Level = FeedbackMessageLevel.SUCCESS,
                Message = message,
                Reporter = reporter
            };
        }

        /// <summary>
        /// Creates warning feedback message.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="reporter"></param>
        /// <returns></returns>
        public static FeedbackMessage Warn(Object message, Control reporter = null)
        {
            return new FeedbackMessage()
            {
                Level = FeedbackMessageLevel.WARN,
                Message = message,
                Reporter = reporter
            };
        }

        /// <summary>
        /// Creates error feedback message.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="reporter"></param>
        /// <returns></returns>
        public static FeedbackMessage Error(Object message, Control reporter = null)
        {
            return new FeedbackMessage()
            {
                Level = FeedbackMessageLevel.ERROR,
                Message = message,
                Reporter = reporter
            };
        }

        /// <summary>
        /// The message level
        /// </summary>
        public FeedbackMessageLevel Level { get; set; }

        /// <summary>
        /// The message body
        /// </summary>
        public Object Message { get; set; }

        /// <summary>
        /// The message reporter
        /// </summary>
        public Control Reporter { get; set; }

        /// <summary>
        /// Wheter message is rendered or not
        /// </summary>
        public bool IsRendered { get; private set; }

        /// <summary>
        /// Change state to rendered.
        /// </summary>
        public void MarkRender()
        {
            IsRendered = true;
        }


    }
}