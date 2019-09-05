/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class QueryMarketImagesResponseUnmarshaller
    {
        public static QueryMarketImagesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMarketImagesResponse queryMarketImagesResponse = new QueryMarketImagesResponse();

			queryMarketImagesResponse.HttpResponse = context.HttpResponse;
			queryMarketImagesResponse.PageNumber = context.IntegerValue("QueryMarketImages.PageNumber");
			queryMarketImagesResponse.PageSize = context.IntegerValue("QueryMarketImages.PageSize");
			queryMarketImagesResponse.TotalCount = context.IntegerValue("QueryMarketImages.TotalCount");
			queryMarketImagesResponse.RequestId = context.StringValue("QueryMarketImages.RequestId");

			List<QueryMarketImagesResponse.QueryMarketImages_ImageProduct> queryMarketImagesResponse_result = new List<QueryMarketImagesResponse.QueryMarketImages_ImageProduct>();
			for (int i = 0; i < context.Length("QueryMarketImages.Result.Length"); i++) {
				QueryMarketImagesResponse.QueryMarketImages_ImageProduct imageProduct = new QueryMarketImagesResponse.QueryMarketImages_ImageProduct();
				imageProduct.ImageProductCode = context.StringValue("QueryMarketImages.Result["+ i +"].ImageProductCode");
				imageProduct.ProductName = context.StringValue("QueryMarketImages.Result["+ i +"].ProductName");
				imageProduct.CategoryName = context.StringValue("QueryMarketImages.Result["+ i +"].CategoryName");
				imageProduct.SupplierName = context.StringValue("QueryMarketImages.Result["+ i +"].SupplierName");
				imageProduct.BaseSystem = context.StringValue("QueryMarketImages.Result["+ i +"].BaseSystem");
				imageProduct.OsKind = context.StringValue("QueryMarketImages.Result["+ i +"].OsKind");
				imageProduct.OsBit = context.IntegerValue("QueryMarketImages.Result["+ i +"].OsBit");
				imageProduct.PictureUrl = context.StringValue("QueryMarketImages.Result["+ i +"].PictureUrl");
				imageProduct.SmallPicUrl = context.StringValue("QueryMarketImages.Result["+ i +"].SmallPicUrl");
				imageProduct.ShortDescription = context.StringValue("QueryMarketImages.Result["+ i +"].ShortDescription");
				imageProduct.AgreementUrl = context.StringValue("QueryMarketImages.Result["+ i +"].AgreementUrl");
				imageProduct.DetailUrl = context.StringValue("QueryMarketImages.Result["+ i +"].DetailUrl");
				imageProduct.BuyUrl = context.StringValue("QueryMarketImages.Result["+ i +"].BuyUrl");
				imageProduct.StoreUrl = context.StringValue("QueryMarketImages.Result["+ i +"].StoreUrl");
				imageProduct.Score = context.FloatValue("QueryMarketImages.Result["+ i +"].Score");
				imageProduct.UserCount = context.LongValue("QueryMarketImages.Result["+ i +"].UserCount");
				imageProduct.SupportIO = context.BooleanValue("QueryMarketImages.Result["+ i +"].SupportIO");
				imageProduct.CreatedOn = context.LongValue("QueryMarketImages.Result["+ i +"].CreatedOn");

				List<string> imageProduct_skuCodes = new List<string>();
				for (int j = 0; j < context.Length("QueryMarketImages.Result["+ i +"].SkuCodes.Length"); j++) {
					imageProduct_skuCodes.Add(context.StringValue("QueryMarketImages.Result["+ i +"].SkuCodes["+ j +"]"));
				}
				imageProduct.SkuCodes = imageProduct_skuCodes;

				QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_Quota quota = new QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_Quota();
				quota.TotalQuota = context.LongValue("QueryMarketImages.Result["+ i +"].Quota.TotalQuota");
				quota.UsingQuota = context.LongValue("QueryMarketImages.Result["+ i +"].Quota.UsingQuota");
				quota.UnusedQuota = context.LongValue("QueryMarketImages.Result["+ i +"].Quota.UnusedQuota");
				imageProduct.Quota = quota;

				QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_PriceInfo priceInfo = new QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_PriceInfo();

				QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_PriceInfo.QueryMarketImages_Order order = new QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_PriceInfo.QueryMarketImages_Order();
				order.OriginalPrice = context.FloatValue("QueryMarketImages.Result["+ i +"].PriceInfo.Order.OriginalPrice");
				order.DiscountPrice = context.FloatValue("QueryMarketImages.Result["+ i +"].PriceInfo.Order.DiscountPrice");
				order.TradePrice = context.FloatValue("QueryMarketImages.Result["+ i +"].PriceInfo.Order.TradePrice");
				order.Currency = context.StringValue("QueryMarketImages.Result["+ i +"].PriceInfo.Order.Currency");
				order.Period = context.IntegerValue("QueryMarketImages.Result["+ i +"].PriceInfo.Order.Period");
				order.PriceUnit = context.StringValue("QueryMarketImages.Result["+ i +"].PriceInfo.Order.PriceUnit");

				List<string> order_ruleIdSet = new List<string>();
				for (int j = 0; j < context.Length("QueryMarketImages.Result["+ i +"].PriceInfo.Order.RuleIdSet.Length"); j++) {
					order_ruleIdSet.Add(context.StringValue("QueryMarketImages.Result["+ i +"].PriceInfo.Order.RuleIdSet["+ j +"]"));
				}
				order.RuleIdSet = order_ruleIdSet;
				priceInfo.Order = order;

				List<QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_PriceInfo.QueryMarketImages_Rule> priceInfo_rules = new List<QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_PriceInfo.QueryMarketImages_Rule>();
				for (int j = 0; j < context.Length("QueryMarketImages.Result["+ i +"].PriceInfo.Rules.Length"); j++) {
					QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_PriceInfo.QueryMarketImages_Rule rule = new QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_PriceInfo.QueryMarketImages_Rule();
					rule.RuleId = context.LongValue("QueryMarketImages.Result["+ i +"].PriceInfo.Rules["+ j +"].RuleId");
					rule.Title = context.StringValue("QueryMarketImages.Result["+ i +"].PriceInfo.Rules["+ j +"].Title");
					rule.Name = context.StringValue("QueryMarketImages.Result["+ i +"].PriceInfo.Rules["+ j +"].Name");

					priceInfo_rules.Add(rule);
				}
				priceInfo.Rules = priceInfo_rules;
				imageProduct.PriceInfo = priceInfo;

				List<QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_Image> imageProduct_images = new List<QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_Image>();
				for (int j = 0; j < context.Length("QueryMarketImages.Result["+ i +"].Images.Length"); j++) {
					QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_Image image = new QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_Image();
					image.Version = context.StringValue("QueryMarketImages.Result["+ i +"].Images["+ j +"].Version");
					image.VersionDescription = context.StringValue("QueryMarketImages.Result["+ i +"].Images["+ j +"].VersionDescription");
					image.ImageId = context.StringValue("QueryMarketImages.Result["+ i +"].Images["+ j +"].ImageId");
					image.ImageSize = context.IntegerValue("QueryMarketImages.Result["+ i +"].Images["+ j +"].ImageSize");
					image.Region = context.StringValue("QueryMarketImages.Result["+ i +"].Images["+ j +"].Region");
					image.IsDefault = context.BooleanValue("QueryMarketImages.Result["+ i +"].Images["+ j +"].IsDefault");
					image.SupportIO = context.BooleanValue("QueryMarketImages.Result["+ i +"].Images["+ j +"].SupportIO");

					List<QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_Image.QueryMarketImages_DiskDeviceMapping> image_diskDeviceMappings = new List<QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_Image.QueryMarketImages_DiskDeviceMapping>();
					for (int k = 0; k < context.Length("QueryMarketImages.Result["+ i +"].Images["+ j +"].DiskDeviceMappings.Length"); k++) {
						QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_Image.QueryMarketImages_DiskDeviceMapping diskDeviceMapping = new QueryMarketImagesResponse.QueryMarketImages_ImageProduct.QueryMarketImages_Image.QueryMarketImages_DiskDeviceMapping();
						diskDeviceMapping.DiskType = context.StringValue("QueryMarketImages.Result["+ i +"].Images["+ j +"].DiskDeviceMappings["+ k +"].DiskType");
						diskDeviceMapping.Format = context.StringValue("QueryMarketImages.Result["+ i +"].Images["+ j +"].DiskDeviceMappings["+ k +"].Format");
						diskDeviceMapping.SnapshotId = context.StringValue("QueryMarketImages.Result["+ i +"].Images["+ j +"].DiskDeviceMappings["+ k +"].SnapshotId");
						diskDeviceMapping.Size = context.IntegerValue("QueryMarketImages.Result["+ i +"].Images["+ j +"].DiskDeviceMappings["+ k +"].Size");
						diskDeviceMapping.Device = context.StringValue("QueryMarketImages.Result["+ i +"].Images["+ j +"].DiskDeviceMappings["+ k +"].Device");
						diskDeviceMapping.ImportOSSBucket = context.StringValue("QueryMarketImages.Result["+ i +"].Images["+ j +"].DiskDeviceMappings["+ k +"].ImportOSSBucket");
						diskDeviceMapping.ImportOSSObject = context.StringValue("QueryMarketImages.Result["+ i +"].Images["+ j +"].DiskDeviceMappings["+ k +"].ImportOSSObject");

						image_diskDeviceMappings.Add(diskDeviceMapping);
					}
					image.DiskDeviceMappings = image_diskDeviceMappings;

					imageProduct_images.Add(image);
				}
				imageProduct.Images = imageProduct_images;

				queryMarketImagesResponse_result.Add(imageProduct);
			}
			queryMarketImagesResponse.Result = queryMarketImagesResponse_result;
        
			return queryMarketImagesResponse;
        }
    }
}
