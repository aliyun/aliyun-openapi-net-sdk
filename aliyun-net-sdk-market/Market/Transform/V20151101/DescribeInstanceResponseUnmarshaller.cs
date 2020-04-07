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
        public static DescribeInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceResponse describeInstanceResponse = new DescribeInstanceResponse();

			describeInstanceResponse.HttpResponse = context.HttpResponse;
			describeInstanceResponse.InstanceId = context.LongValue("DescribeInstance.InstanceId");
			describeInstanceResponse.OrderId = context.LongValue("DescribeInstance.OrderId");
			describeInstanceResponse.SupplierName = context.StringValue("DescribeInstance.SupplierName");
			describeInstanceResponse.ProductCode = context.StringValue("DescribeInstance.ProductCode");
			describeInstanceResponse.ProductSkuCode = context.StringValue("DescribeInstance.ProductSkuCode");
			describeInstanceResponse.ProductName = context.StringValue("DescribeInstance.ProductName");
			describeInstanceResponse.ProductType = context.StringValue("DescribeInstance.ProductType");
			describeInstanceResponse.Status = context.StringValue("DescribeInstance.Status");
			describeInstanceResponse.BeganOn = context.LongValue("DescribeInstance.BeganOn");
			describeInstanceResponse.EndOn = context.LongValue("DescribeInstance.EndOn");
			describeInstanceResponse.CreatedOn = context.LongValue("DescribeInstance.CreatedOn");
			describeInstanceResponse.ExtendJson = context.StringValue("DescribeInstance.ExtendJson");
			describeInstanceResponse.HostJson = context.StringValue("DescribeInstance.HostJson");
			describeInstanceResponse.AppJson = context.StringValue("DescribeInstance.AppJson");
			describeInstanceResponse.ComponentJson = context.StringValue("DescribeInstance.ComponentJson");
			describeInstanceResponse.Constraints = context.StringValue("DescribeInstance.Constraints");
			describeInstanceResponse.IsTrial = context.BooleanValue("DescribeInstance.IsTrial");

			DescribeInstanceResponse.DescribeInstance_RelationalData relationalData = new DescribeInstanceResponse.DescribeInstance_RelationalData();
			relationalData.ServiceStatus = context.StringValue("DescribeInstance.RelationalData.ServiceStatus");
			describeInstanceResponse.RelationalData = relationalData;

			List<DescribeInstanceResponse.DescribeInstance_Module> describeInstanceResponse_modules = new List<DescribeInstanceResponse.DescribeInstance_Module>();
			for (int i = 0; i < context.Length("DescribeInstance.Modules.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Module module = new DescribeInstanceResponse.DescribeInstance_Module();
				module.Id = context.StringValue("DescribeInstance.Modules["+ i +"].Id");
				module.Name = context.StringValue("DescribeInstance.Modules["+ i +"].Name");
				module.Code = context.StringValue("DescribeInstance.Modules["+ i +"].Code");

				List<DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property> module_properties = new List<DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property>();
				for (int j = 0; j < context.Length("DescribeInstance.Modules["+ i +"].Properties.Length"); j++) {
					DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property property = new DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property();
					property.Name = context.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].Name");
					property.Key = context.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].Key");
					property.ShowType = context.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].ShowType");
					property.DisplayUnit = context.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].DisplayUnit");

					List<DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property.DescribeInstance_PropertyValue> property_propertyValues = new List<DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property.DescribeInstance_PropertyValue>();
					for (int k = 0; k < context.Length("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues.Length"); k++) {
						DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property.DescribeInstance_PropertyValue propertyValue = new DescribeInstanceResponse.DescribeInstance_Module.DescribeInstance_Property.DescribeInstance_PropertyValue();
						propertyValue._Value = context.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues["+ k +"].Value");
						propertyValue.DisplayName = context.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues["+ k +"].DisplayName");
						propertyValue.Type = context.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues["+ k +"].Type");
						propertyValue.Min = context.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues["+ k +"].Min");
						propertyValue.Max = context.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues["+ k +"].Max");
						propertyValue.Step = context.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues["+ k +"].Step");
						propertyValue.Remark = context.StringValue("DescribeInstance.Modules["+ i +"].Properties["+ j +"].PropertyValues["+ k +"].Remark");

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
