/*
 * Copyright 2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

#import "AppDelegate.h"

@implementation AppDelegate	
NSString *token;
- (BOOL)application:(UIApplication *)application didFinishLaunchingWithOptions:(NSDictionary *)launchOptions{
	application.applicationIconBadgeNumber = 0;
    [[UIApplication sharedApplication] registerForRemoteNotificationTypes:
     (UIRemoteNotificationTypeBadge | UIRemoteNotificationTypeSound | UIRemoteNotificationTypeAlert)];
    if(launchOptions!=nil){
        NSString *msg = [NSString stringWithFormat:@"%@", launchOptions];
        NSLog(@"%@",msg);
       [self createAlert:msg];
       //[[UIApplication sharedApplication] openURL:[NSURL URLWithString:@"http://tinyurl.com/lkpxo9y"]];
    }
    return YES;
}
//- (void)application:(UIApplication*)application didRegisterForRemoteNotificationsWithDeviceToken:(NSData*)deviceToken{
//	NSLog(@"deviceToken: %@",deviceToken);
//   token = [NSString stringWithFormat:@"%@", deviceToken];
//      [self createAlert:token];}
//this should now work please let me know
//- (void)application:(UIApplication*)application didFailToRegisterForRemoteNotificationsWithError:(NSError*)error{
//	NSLog(@"Failed to register with error : %@", error);

 //  }

- (void)application:(UIApplication*)application didRegisterForRemoteNotificationsWithDeviceToken:(NSData*)deviceToken{
	NSLog(@"deviceToken: %@", deviceToken);
    
   // [self createAlert: deviceToken];
}

- (void)application:(UIApplication*)application didFailToRegisterForRemoteNotificationsWithError:(NSError*)error{
	NSLog(@"Failed to register with error : %@", error);
    
   // [self createAlert: error];
}

- (void)application:(UIApplication *)application didReceiveRemoteNotification:(NSDictionary *)userInfo {
    application.applicationIconBadgeNumber = 0;
    NSString *msg = [NSString stringWithFormat:@"%@", userInfo];
    NSLog(@"%@",msg);
  //   [self createAlert:msg];
   
   
   [[UIApplication sharedApplication] openURL:[NSURL URLWithString:@"http://tinyurl.com/lkpxo9y"]];
}

- (void)createAlert:(NSString *)msg {
    UIAlertView *alertView = [[UIAlertView alloc] initWithTitle:@"Saleslogix" message:[NSString stringWithFormat:@"%@", msg]delegate:self cancelButtonTitle:@"OK" otherButtonTitles:nil];
   [alertView show];
}

@end
