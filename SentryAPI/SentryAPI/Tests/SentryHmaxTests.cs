﻿using NUnit.Framework;
using SentryAPI.SentrydesDataApiService;

namespace JPL_API_Testing.SentryAPI.Tests
{
    public class SentryHmaxTests
    {
        private SentryHmaxDataAPIService _sentryDataApiService = new SentryHmaxDataAPIService(99);

        [Test]
        public void CallingAPI_CorrectVersionResponse()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.hmaxData.signature.version, Is.EqualTo("1.1"));
        }

        [Test]
        public void CallingAPI_CorrectSourceResponse()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.hmaxData.signature.source, Is.EqualTo("NASA/JPL Sentry Data API"));
        }

        [Test]
        public void CallingAPI_CorrectCountResponse()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.hmaxData.count, Is.Not.Null.Or.Zero);
        }
    }
}