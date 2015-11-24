[DEPRECATED] Meridium.ShareCountService
---
**Deprecation Notice**
Due to the endpoint removal by Twitter this repo is now pronounced dead. 
More information found here: https://blog.twitter.com/2015/hard-decisions-for-a-sustainable-platform 

The Search API has limitations to only 7 days history and the Streaming API requires user context authentication, making it difficult to provide this as a reliable service on a SaaS basis.

You should probably find better and more valuable metrics to analyze rather than shares per URL anyways.

---

[![Build status](https://ci.appveyor.com/api/projects/status/smvsn5369evdnfg7/branch/master?svg=true)](https://ci.appveyor.com/project/kimgunnarsson/meridium-sharecountservice/branch/master)

A service for retrieving and concatenation of share counts for various social media endpoints.

## Usage 

Instancing the service:

`var shareCountService = new ShareCountService();`

Add URLs to get count for:

`var keys = new List<string>() {"http://www.meridium.se", "http://www.github.com"};`

Retrieve Shares:

`var shares = shareCountService.GetShares(keys);`

## Currently supporting
- Facebook Open Graph
- Twitter API


## Dependencies
- [JSON.net](https://www.nuget.org/packages/Newtonsoft.Json/5.0.8)
- [NUnit](https://www.nuget.org/packages/NUnit/)
