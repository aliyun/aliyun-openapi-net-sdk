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
        public static DescribeProductResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProductResponse describeProductResponse = new DescribeProductResponse();

			describeProductResponse.HttpResponse = _ctx.HttpResponse;
			describeProductResponse.FrontCategoryId = _ctx.LongValue("DescribeProduct.FrontCategoryId");
			describeProductResponse.Status = _ctx.StringValue("DescribeProduct.Status");
			describeProductResponse.Type = _ctx.StringValue("DescribeProduct.Type");
			describeProductResponse.PicUrl = _ctx.StringValue("DescribeProduct.PicUrl");
			describeProductResponse.Score = _ctx.FloatValue("DescribeProduct.Score");
			describeProductResponse.UseCount = _ctx.LongValue("DescribeProduct.UseCount");
			describeProductResponse.GmtModified = _ctx.LongValue("DescribeProduct.GmtModified");
			describeProductResponse.SupplierPk = _ctx.LongValue("DescribeProduct.SupplierPk");
			describeProductResponse.GmtCreated = _ctx.LongValue("DescribeProduct.GmtCreated");
			describeProductResponse.RequestId = _ctx.StringValue("DescribeProduct.RequestId");
			describeProductResponse.ShortDescription = _ctx.StringValue("DescribeProduct.ShortDescription");
			describeProductResponse.Description = _ctx.StringValue("DescribeProduct.Description");
			describeProductResponse.Code = _ctx.StringValue("DescribeProduct.Code");
			describeProductResponse.AuditFailMsg = _ctx.StringValue("DescribeProduct.AuditFailMsg");
			describeProductResponse.Name = _ctx.StringValue("DescribeProduct.Name");
			describeProductResponse.AuditTime = _ctx.LongValue("DescribeProduct.AuditTime");
			describeProductResponse.AuditStatus = _ctx.StringValue("DescribeProduct.AuditStatus");

			DescribeProductResponse.DescribeProduct_ShopInfo shopInfo = new DescribeProductResponse.DescribeProduct_ShopInfo();
			shopInfo.Name = _ctx.StringValue("DescribeProduct.ShopInfo.Name");
			shopInfo.Emails = _ctx.StringValue("DescribeProduct.ShopInfo.Emails");
			shopInfo.Id = _ctx.LongValue("DescribeProduct.ShopInfo.Id");

			List<string> shopInfo_telephones = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeProduct.ShopInfo.Telephones.Length"); i++) {
				shopInfo_telephones.Add(_ctx.StringValue("DescribeProduct.ShopInfo.Telephones["+ i +"]"));
			}
			shopInfo.Telephones = shopInfo_telephones;

			List<DescribeProductResponse.DescribeProduct_ShopInfo.DescribeProduct_WangWang> shopInfo_wangWangs = new List<DescribeProductResponse.DescribeProduct_ShopInfo.DescribeProduct_WangWang>();
			for (int i = 0; i < _ctx.Length("DescribeProduct.ShopInfo.WangWangs.Length"); i++) {
				DescribeProductResponse.DescribeProduct_ShopInfo.DescribeProduct_WangWang wangWang = new DescribeProductResponse.DescribeProduct_ShopInfo.DescribeProduct_WangWang();
				wangWang.Remark = _ctx.StringValue("DescribeProduct.ShopInfo.WangWangs["+ i +"].Remark");
				wangWang.UserName = _ctx.StringValue("DescribeProduct.ShopInfo.WangWangs["+ i +"].UserName");

				shopInfo_wangWangs.Add(wangWang);
			}
			shopInfo.WangWangs = shopInfo_wangWangs;
			describeProductResponse.ShopInfo = shopInfo;

			List<DescribeProductResponse.DescribeProduct_ProductSku> describeProductResponse_productSkus = new List<DescribeProductResponse.DescribeProduct_ProductSku>();
			for (int i = 0; i < _ctx.Length("DescribeProduct.ProductSkus.Length"); i++) {
				DescribeProductResponse.DescribeProduct_ProductSku productSku = new DescribeProductResponse.DescribeProduct_ProductSku();
				productSku.Hidden = _ctx.BooleanValue("DescribeProduct.ProductSkus["+ i +"].Hidden");
				productSku.Code = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Code");
				productSku.Constraints = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Constraints");
				productSku.Name = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Name");
				productSku.ChargeType = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].ChargeType");

				List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_OrderPeriod> productSku_orderPeriods = new List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_OrderPeriod>();
				for (int j = 0; j < _ctx.Length("DescribeProduct.ProductSkus["+ i +"].OrderPeriods.Length"); j++) {
					DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_OrderPeriod orderPeriod = new DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_OrderPeriod();
					orderPeriod.Name = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].OrderPeriods["+ j +"].Name");
					orderPeriod.PeriodType = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].OrderPeriods["+ j +"].PeriodType");

					productSku_orderPeriods.Add(orderPeriod);
				}
				productSku.OrderPeriods = productSku_orderPeriods;

				List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module> productSku_modules = new List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module>();
				for (int j = 0; j < _ctx.Length("DescribeProduct.ProductSkus["+ i +"].Modules.Length"); j++) {
					DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module module = new DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module();
					module.Code = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Code");
					module.Name = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Name");
					module.Id = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Id");

					List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property> module_properties = new List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property>();
					for (int k = 0; k < _ctx.Length("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties.Length"); k++) {
						DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property property = new DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property();
						property.Key = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].Key");
						property.ShowType = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].ShowType");
						property.Name = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].Name");
						property.DisplayUnit = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].DisplayUnit");

						List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property.DescribeProduct_PropertyValue> property_propertyValues = new List<DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property.DescribeProduct_PropertyValue>();
						for (int l = 0; l < _ctx.Length("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues.Length"); l++) {
							DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property.DescribeProduct_PropertyValue propertyValue = new DescribeProductResponse.DescribeProduct_ProductSku.DescribeProduct_Module.DescribeProduct_Property.DescribeProduct_PropertyValue();
							propertyValue.DisplayName = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues["+ l +"].DisplayName");
							propertyValue.Type = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues["+ l +"].Type");
							propertyValue.Step = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues["+ l +"].Step");
							propertyValue._Value = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues["+ l +"].Value");
							propertyValue.Max = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues["+ l +"].Max");
							propertyValue.Remark = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues["+ l +"].Remark");
							propertyValue.Min = _ctx.StringValue("DescribeProduct.ProductSkus["+ i +"].Modules["+ j +"].Properties["+ k +"].PropertyValues["+ l +"].Min");

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
			for (int i = 0; i < _ctx.Length("DescribeProduct.ProductExtras.Length"); i++) {
				DescribeProductResponse.DescribeProduct_ProductExtra productExtra = new DescribeProductResponse.DescribeProduct_ProductExtra();
				productExtra.Type = _ctx.StringValue("DescribeProduct.ProductExtras["+ i +"].Type");
				productExtra.Key = _ctx.StringValue("DescribeProduct.ProductExtras["+ i +"].Key");
				productExtra.Label = _ctx.StringValue("DescribeProduct.ProductExtras["+ i +"].Label");
				productExtra.Order = _ctx.IntegerValue("DescribeProduct.ProductExtras["+ i +"].Order");
				productExtra.Values = _ctx.StringValue("DescribeProduct.ProductExtras["+ i +"].Values");

				describeProductResponse_productExtras.Add(productExtra);
			}
			describeProductResponse.ProductExtras = describeProductResponse_productExtras;
        
			return describeProductResponse;
        }
    }
}
