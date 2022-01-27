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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class DescribeResourcePackageProductResponseUnmarshaller
    {
        public static DescribeResourcePackageProductResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeResourcePackageProductResponse describeResourcePackageProductResponse = new DescribeResourcePackageProductResponse();

			describeResourcePackageProductResponse.HttpResponse = _ctx.HttpResponse;
			describeResourcePackageProductResponse.RequestId = _ctx.StringValue("DescribeResourcePackageProduct.RequestId");
			describeResourcePackageProductResponse.OrderId = _ctx.LongValue("DescribeResourcePackageProduct.OrderId");
			describeResourcePackageProductResponse.Success = _ctx.BooleanValue("DescribeResourcePackageProduct.Success");
			describeResourcePackageProductResponse.Code = _ctx.StringValue("DescribeResourcePackageProduct.Code");
			describeResourcePackageProductResponse.Message = _ctx.StringValue("DescribeResourcePackageProduct.Message");

			DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data data = new DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data();

			List<DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage> data_resourcePackages = new List<DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage>();
			for (int i = 0; i < _ctx.Length("DescribeResourcePackageProduct.Data.ResourcePackages.Length"); i++) {
				DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage resourcePackage = new DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage();
				resourcePackage.ProductCode = _ctx.StringValue("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].ProductCode");
				resourcePackage.ProductType = _ctx.StringValue("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].ProductType");
				resourcePackage.Name = _ctx.StringValue("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].Name");

				List<DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType> resourcePackage_packageTypes = new List<DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType>();
				for (int j = 0; j < _ctx.Length("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].PackageTypes.Length"); j++) {
					DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType packageType = new DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType();
					packageType.Name = _ctx.StringValue("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].PackageTypes["+ j +"].Name");
					packageType.Code = _ctx.StringValue("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].PackageTypes["+ j +"].Code");

					List<DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType.DescribeResourcePackageProduct_Property> packageType_properties = new List<DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType.DescribeResourcePackageProduct_Property>();
					for (int k = 0; k < _ctx.Length("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].PackageTypes["+ j +"].Properties.Length"); k++) {
						DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType.DescribeResourcePackageProduct_Property property = new DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType.DescribeResourcePackageProduct_Property();
						property.Name = _ctx.StringValue("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].PackageTypes["+ j +"].Properties["+ k +"].Name");
						property._Value = _ctx.StringValue("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].PackageTypes["+ j +"].Properties["+ k +"].Value");

						packageType_properties.Add(property);
					}
					packageType.Properties = packageType_properties;

					List<DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType.DescribeResourcePackageProduct_Specification> packageType_specifications = new List<DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType.DescribeResourcePackageProduct_Specification>();
					for (int k = 0; k < _ctx.Length("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].PackageTypes["+ j +"].Specifications.Length"); k++) {
						DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType.DescribeResourcePackageProduct_Specification specification = new DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType.DescribeResourcePackageProduct_Specification();
						specification.Name = _ctx.StringValue("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].PackageTypes["+ j +"].Specifications["+ k +"].Name");
						specification._Value = _ctx.StringValue("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].PackageTypes["+ j +"].Specifications["+ k +"].Value");

						List<DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType.DescribeResourcePackageProduct_Specification.DescribeResourcePackageProduct_AvailableDuration> specification_availableDurations = new List<DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType.DescribeResourcePackageProduct_Specification.DescribeResourcePackageProduct_AvailableDuration>();
						for (int l = 0; l < _ctx.Length("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].PackageTypes["+ j +"].Specifications["+ k +"].AvailableDurations.Length"); l++) {
							DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType.DescribeResourcePackageProduct_Specification.DescribeResourcePackageProduct_AvailableDuration availableDuration = new DescribeResourcePackageProductResponse.DescribeResourcePackageProduct_Data.DescribeResourcePackageProduct_ResourcePackage.DescribeResourcePackageProduct_PackageType.DescribeResourcePackageProduct_Specification.DescribeResourcePackageProduct_AvailableDuration();
							availableDuration.Name = _ctx.StringValue("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].PackageTypes["+ j +"].Specifications["+ k +"].AvailableDurations["+ l +"].Name");
							availableDuration._Value = _ctx.IntegerValue("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].PackageTypes["+ j +"].Specifications["+ k +"].AvailableDurations["+ l +"].Value");
							availableDuration.Unit = _ctx.StringValue("DescribeResourcePackageProduct.Data.ResourcePackages["+ i +"].PackageTypes["+ j +"].Specifications["+ k +"].AvailableDurations["+ l +"].Unit");

							specification_availableDurations.Add(availableDuration);
						}
						specification.AvailableDurations = specification_availableDurations;

						packageType_specifications.Add(specification);
					}
					packageType.Specifications = packageType_specifications;

					resourcePackage_packageTypes.Add(packageType);
				}
				resourcePackage.PackageTypes = resourcePackage_packageTypes;

				data_resourcePackages.Add(resourcePackage);
			}
			data.ResourcePackages = data_resourcePackages;
			describeResourcePackageProductResponse.Data = data;
        
			return describeResourcePackageProductResponse;
        }
    }
}
