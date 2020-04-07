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
    public class DescribeProductResponseUnmarshaller
    {
        public static DescribeProductResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeProductResponse describeProductResponse = new DescribeProductResponse();

			describeProductResponse.HttpResponse = context.HttpResponse;
			describeProductResponse.Code = context.StringValue("DescribeProduct.Code");
			describeProductResponse.Name = context.StringValue("DescribeProduct.Name");
			describeProductResponse.Type = context.StringValue("DescribeProduct.Type");
			describeProductResponse.PicUrl = context.StringValue("DescribeProduct.PicUrl");
			describeProductResponse.Description = context.StringValue("DescribeProduct.Description");
			describeProductResponse.ShortDescription = context.StringValue("DescribeProduct.ShortDescription");
			describeProductResponse.UseCount = context.LongValue("DescribeProduct.UseCount");
			describeProductResponse.Score = context.FloatValue("DescribeProduct.Score");
			describeProductResponse.Status = context.StringValue("DescribeProduct.Status");
			describeProductResponse.AuditStatus = context.StringValue("DescribeProduct.AuditStatus");
			describeProductResponse.AuditFailMsg = context.StringValue("DescribeProduct.AuditFailMsg");
			describeProductResponse.AuditTime = context.LongValue("DescribeProduct.AuditTime");
			describeProductResponse.GmtCreated = context.LongValue("DescribeProduct.GmtCreated");
			describeProductResponse.GmtModified = context.LongValue("DescribeProduct.GmtModified");
			describeProductResponse.RequestId = context.StringValue("DescribeProduct.RequestId");
			describeProductResponse.SupplierPk = context.LongValue("DescribeProduct.SupplierPk");
			describeProductResponse.FrontCategoryId = context.LongValue("DescribeProduct.FrontCategoryId");

			DescribeProductResponse.DescribeProduct_ShopInfo shopInfo = new DescribeProductResponse.DescribeProduct_ShopInfo();
			shopInfo.Id = context.LongValue("DescribeProduct.ShopInfo.Id");
			shopInfo.Name = context.StringValue("DescribeProduct.ShopInfo.Name");
			shopInfo.Emails = context.StringValue("DescribeProduct.ShopInfo.Emails");

			List<string> shopInfo_telephones = new List<string>();
			for (int i = 0; i < context.Length("DescribeProduct.ShopInfo.Telephones.Length"); i++) {
				shopInfo_telephones.Add(context.StringValue("DescribeProduct.ShopInfo.Telephones["+ i +"]"));
			}
			shopInfo.Telephones = shopInfo_telephones;

			List<DescribeProductResponse.DescribeProduct_ShopInfo.DescribeProduct_WangWang> shopInfo_wangWangs = new List<DescribeProductResponse.DescribeProduct_ShopInfo.DescribeProduct_WangWang>();
			for (int i = 0; i < context.Length("DescribeProduct.ShopInfo.WangWangs.Length"); i++) {
				DescribeProductResponse.DescribeProduct_ShopInfo.DescribeProduct_WangWang wangWang = new DescribeProductResponse.DescribeProduct_ShopInfo.DescribeProduct_WangWang();
				wangWang.UserName = context.StringValue("DescribeProduct.ShopInfo.WangWangs["+ i +"].UserName");
				wangWang.Remark = context.StringValue("DescribeProduct.ShopInfo.WangWangs["+ i +"].Remark");

				shopInfo_wangWangs.Add(wangWang);
			}
			shopInfo.WangWangs = shopInfo_wangWangs;
			describeProductResponse.ShopInfo = shopInfo;

			List<DescribeProductResponse.DescribeProduct_ProductSku> describeProductResponse_productSkus = new List<DescribeProductResponse.DescribeProduct_ProductSku>();
			for (int i = 0; i < context.Length("DescribeProduct.ProductSkus.Length"); i++) {
				DescribeProductResponse.DescribeProduct_ProductSku productSku = new DescribeProductResponse.DescribeProduct_ProductSku();
				productSku.Name = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Name");
				productSku.Code = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Code");
				productSku.ChargeType = context.StringValue("DescribeProduct.ProductSkus["+ i +"].ChargeType");
				productSku.Constraints = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Constraints");
				productSku.Hidden = context.BooleanValue("DescribeProduct.ProductSkus["+ i +"].Hidden");

				List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_OrderPeriod> productSku_orderPeriods = new List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_OrderPeriod>();
				for (int j = 0; j < context.Length("DescribeProduct.ProductSkus["+ i +"].OrderPeriods.Length"); j++) {
					DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_OrderPeriod orderPeriod = new DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_OrderPeriod();
					orderPeriod.Name = context.StringValue("DescribeProduct.ProductSkus["+ i +"].OrderPeriods["+ j +"].Name");
					orderPeriod.PeriodType = context.StringValue("DescribeProduct.ProductSkus["+ i +"].OrderPeriods["+ j +"].PeriodType");

					productSku_orderPeriods.Add(orderPeriod);
				}
				productSku.OrderPeriods = productSku_orderPeriods;

				List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module> productSku_modules = new List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module>();
				for (int j = 0; j < context.Length("DescribeProduct.ProductSkus["+ i +"].Modules.Length"); j++) {
					DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module module = new DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module();
					module.Id = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Id");
					module.Name = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Name");
					module.Code = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Code");

					List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property> module_properties = new List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property>();
					for (int k = 0; k < context.Length("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties.Length"); k++) {
						DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property property = new DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property();
						property.Name = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].Name");
						property.Key = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].Key");
						property.ShowType = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].ShowType");
						property.DisplayUnit = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].DisplayUnit");

						List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property.DescribeProduct_PropertyValue> property_propertyValues = new List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property.DescribeProduct_PropertyValue>();
						for (int l = 0; l < context.Length("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues.Length"); l++) {
							DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property.DescribeProduct_PropertyValue propertyValue = new DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property.DescribeProduct_PropertyValue();
							propertyValue._Value = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues["+ l +"].Value");
							propertyValue.DisplayName = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues["+ l +"].DisplayName");
							propertyValue.Type = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues["+ l +"].Type");
							propertyValue.Min = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues["+ l +"].Min");
							propertyValue.Max = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues["+ l +"].Max");
							propertyValue.Step = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues["+ l +"].Step");
							propertyValue.Remark = context.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues["+ l +"].Remark");

							property_propertyValues.Add(propertyValue);
						}
						property.PropertyValues = property_propertyValues;

						module_properties.Add(property);
					}
					module.Properties = module_properties;

					productSku_modules.Add(module);
				}
				productSku.Modules = productSku_modules;

				describeProductResponse_productSkus.Add(productSku);
			}
			describeProductResponse.ProductSkus = describeProductResponse_productSkus;

			List<DescribeProductResponse.DescribeProduct_ProductExtra> describeProductResponse_productExtras = new List<DescribeProductResponse.DescribeProduct_ProductExtra>();
			for (int i = 0; i < context.Length("DescribeProduct.ProductExtras.Length"); i++) {
				DescribeProductResponse.DescribeProduct_ProductExtra productExtra = new DescribeProductResponse.DescribeProduct_ProductExtra();
				productExtra.Key = context.StringValue("DescribeProduct.ProductExtras["+ i +"].Key");
				productExtra.Values = context.StringValue("DescribeProduct.ProductExtras["+ i +"].Values");
				productExtra.Label = context.StringValue("DescribeProduct.ProductExtras["+ i +"].Label");
				productExtra.Order = context.IntegerValue("DescribeProduct.ProductExtras["+ i +"].Order");
				productExtra.Type = context.StringValue("DescribeProduct.ProductExtras["+ i +"].Type");

				describeProductResponse_productExtras.Add(productExtra);
			}
			describeProductResponse.ProductExtras = describeProductResponse_productExtras;
        
			return describeProductResponse;
        }
    }
}
