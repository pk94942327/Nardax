﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Nardax.UnitTests
{
    
        [TestClass]
        public class QueueExtensionsTests
        {
            Queue<string> _queue;

            public QueueExtensionsTests() //Konstruktor
            {
                _queue = new Queue<string>();
                _queue.Enqueue("aa");
                _queue.Enqueue("bb");
                _queue.Enqueue("cc");

            }

            [TestMethod]
            public void EnquequeRange() //Metod lägg till items.
            {
                _queue.EnqueueRange(new[] { "dd", "ee" });
                Assert.AreEqual("aa", _queue.Dequeue());
                Assert.AreEqual("bb", _queue.Dequeue());
                Assert.AreEqual("cc", _queue.Dequeue());
                Assert.AreEqual("dd", _queue.Dequeue());
                Assert.AreEqual("ee", _queue.Dequeue());
            }

        }
    
}
