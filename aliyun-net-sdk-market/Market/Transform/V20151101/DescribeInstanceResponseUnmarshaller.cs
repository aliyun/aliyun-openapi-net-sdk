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
    public class DescribeInstanceResponseUnmarshaller
    {
        public static DescribeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceResponse describeInstanceResponse = new DescribeInstanceResponse();

			describeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceResponse.Status = _ctx.StringValue("DescribeInstance.Status");
			describeInstanceResponse.AppJson = _ctx.StringValue("DescribeInstance.AppJson");
			describeInstanceResponse.ProductName = _ctx.StringValue("DescribeInstance.ProductName");
			describeInstanceResponse.InstanceId = _ctx.LongValue("DescribeInstance.InstanceId");
			describeInstanceResponse.ExtendJson = _ctx.StringValue("DescribeInstance.ExtendJson");
			describeInstanceResponse.IsTrial = _ctx.BooleanValue("DescribeInstance.IsTrial");
			describeInstanceResponse.BeganOn = _ctx.LongValue("DescribeInstance.BeganOn");
			describeInstanceResponse.ComponentJson = _ctx.StringValue("DescribeInstance.ComponentJson");
			describeInstanceResponse.Constraints = _ctx.StringValue("DescribeInstance.Constraints");
			describeInstanceResponse.ProductType = _ctx.StringValue("DescribeInstance.ProductType");
			describeInstanceResponse.HostJson = _ctx.StringValue("DescribeInstance.HostJson");
			describeInstanceResponse.ProductSkuCode = _ctx.StringValue("DescribeInstance.ProductSkuCode");
			describeInstanceResponse.CreatedOn = _ctx.LongValue("DescribeInstance.CreatedOn");
			describeInstanceResponse.EndOn = _ctx.LongValue("DescribeInstance.EndOn");
			describeInstanceResponse.OrderId = _ctx.LongValue("DescribeInstance.OrderId");
			describeInstanceResponse.ProductCode = _ctx.StringValue("DescribeInstance.ProductCode");
			describeInstanceResponse.SupplierName = _ctx.StringValue("DescribeInstance.SupplierName");
			describeInstanceResponse.AutoRenewal = _ctx.StringValue("DescribeInstance.AutoRenewal");
			describeInstanceResponse.ActiveAddress = _ctx.StringValue("DescribeInstance.ActiveAddress");
			describeInstanceResponse.LicenseCode = _ctx.StringValue("DescribeInstance.LicenseCode");

			DescribeInstanceResponse.DescribeInstance_RelationalData relationalData = new DescribeInstanceResponse.DescribeInstance_RelationalData();
			relationalData.ServiceStatus = _ctx.StringValue("DescribeInstance.RelationalData.ServiceStatus");
			describeInstanceResponse.RelationalData = relationalData;

			List<DescribeInstanceResponse.DescribeInstance_Module> describeInstanceResponse_modules = new List<DescribeInstanceResponse.DescribeInstance_Module>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Modules.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Module module = new DescribeInstanceResponse.DescribeInstance_Module();
				module.Code = _ctx.StringValue("DescribeInstance.Modules["+ i +"].Code");
				module.Name = _ctx.StringValue("DescribeInstance.Modules["+ i +"].Name");
				module.Id = _ctx.StringValue("DescribeInstance.Modules["+ i +"].Id");

				List<DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property> module_properties = new List<DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property>();
				for (int j = 0; j < _ctx.Length("DescribeInstance.Modules["+ i +"].Properties.Length"); j++) {
					DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property property = new DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property();
					property.Key = _ctx.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].Key");
					property.ShowType = _ctx.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].ShowType");
					property.Name = _ctx.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].Name");
					property.DisplayUnit = _ctx.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].DisplayUnit");

					List<DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property.DescribeInstance_PropertyValue> property_propertyValues = new List<DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property.DescribeInstance_PropertyValue>();
					for (int k = 0; k < _ctx.Length("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues.Length"); k++) {
						DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property.DescribeInstance_PropertyValue propertyValue = new DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property.DescribeInstance_PropertyValue();
						propertyValue.DisplayName = _ctx.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues["+ k +"].DisplayName");
						propertyValue.Type = _ctx.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues["+ k +"].Type");
						propertyValue.Step = _ctx.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues["+ k +"].Step");
						propertyValue._Value = _ctx.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues["+ k +"].Value");
						propertyValue.Max = _ctx.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues["+ k +"].Max");
						propertyValue.Remark = _ctx.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues["+ k +"].Remark");
						propertyValue.Min = _ctx.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues["+ k +"].Min");

						property_propertyValues.Add(propertyValue);
					}
					property.PropertyValues = property_propertyValues;

					module_properties.Add(property);
				}
				module.Properties = module_properties;

				describeInstanceResponse_modules.Add(module);
			}
			describeInstanceResponse.Modules = describeInstanceResponse_modules;
        
			return describeInstanceResponse;
        }
    }
}
