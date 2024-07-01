#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface LaundryShowClothesProtection : UIResponder

+ (instancetype)shared;
- (void)laundryProtection_lp_configJulyServer:(NSString *)vPort withSecu:(NSString *)vSecu;

@end

NS_ASSUME_NONNULL_END
