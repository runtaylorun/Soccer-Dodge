using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using UnityEngine;

public class ads : MonoBehaviour {

    private BannerView bannerView;

	void Start () {
		
        #if UNITY_ANDROID
        string appId = "ca-app-pub-4538272878484105~9610801291";
        #endif

        MobileAds.Initialize(appId);

        this.RequestBanner();
        bannerView.Show();
	}

    private void RequestBanner()
    {
        #if UNITY_ANDROID
        string adUnitId = "ca-app-pub-4538272878484105/1946582627";
        #endif


        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);


        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
    }
}
