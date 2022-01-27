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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeAccountAttributesResponseUnmarshaller
    {
        public static DescribeAccountAttributesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccountAttributesResponse describeAccountAttributesResponse = new DescribeAccountAttributesResponse();

			describeAccountAttributesResponse.HttpResponse = _ctx.HttpResponse;
			describeAccountAttributesResponse.RequestId = _ctx.StringValue("DescribeAccountAttributes.RequestId");

			List<DescribeAccountAttributesResponse.DescribeAccountAttributes_AccountAttributeItem> describeAccountAttributesResponse_accountAttributeItems = new List<DescribeAccountAttributesResponse.DescribeAccountAttributes_AccountAttributeItem>();
			for (int i = 0; i < _ctx.Length("DescribeAccountAttributes.AccountAttributeItems.Length"); i++) {
				DescribeAccountAttributesResponse.DescribeAccountAttributes_AccountAttributeItem accountAttributeItem = new DescribeAccountAttributesResponse.DescribeAccountAttributes_AccountAttributeItem();
				accountAttributeItem.AttributeName = _ctx.StringValue("DescribeAccountAttributes.AccountAttributeItems["+ i +"].AttributeName");

				List<DescribeAccountAttributesResponse.DescribeAccountAttributes_AccountAttributeItem.DescribeAccountAttributes_ValueItem> accountAttributeItem_attributeValues = new List<DescribeAccountAttributesResponse.DescribeAccountAttributes_AccountAttributeItem.DescribeAccountAttributes_ValueItem>();
				for (int j = 0; j < _ctx.Length("DescribeAccountAttributes.AccountAttributeItems["+ i +"].AttributeValues.Length"); j++) {
					DescribeAccountAttributesResponse.DescribeAccountAttributes_AccountAttributeItem.DescribeAccountAttributes_ValueItem valueItem = new DescribeAccountAttributesResponse.DescribeAccountAttributes_AccountAttributeItem.DescribeAccountAttributes_ValueItem();
					valueItem.DiskCategory = _ctx.StringValue("DescribeAccountAttributes.AccountAttributeItems["+ i +"].AttributeValues["+ j +"].DiskCategory");
					valueItem._Value = _ctx.StringValue("DescribeAccountAttributes.AccountAttributeItems["+ i +"].AttributeValues["+ j +"].Value");
					valueItem.ExpiredTime = _ctx.StringValue("DescribeAccountAttributes.AccountAttributeItems["+ i +"].AttributeValues["+ j +"].ExpiredTime");
					valueItem.ZoneId = _ctx.StringValue("DescribeAccountAttributes.AccountAttributeItems["+ i +"].AttributeValues["+ j +"].ZoneId");
					valueItem.InstanceType = _ctx.StringValue("DescribeAccountAttributes.AccountAttributeItems["+ i +"].AttributeValues["+ j +"].InstanceType");
					valueItem.Count = _ctx.IntegerValue("DescribeAccountAttributes.AccountAttributeItems["+ i +"].AttributeValues["+ j +"].Count");
					valueItem.InstanceChargeType = _ctx.StringValue("DescribeAccountAttributes.AccountAttributeItems["+ i +"].AttributeValues["+ j +"].InstanceChargeType");

					accountAttributeItem_attributeValues.Add(valueItem);
				}
				accountAttributeItem.AttributeValues = accountAttributeItem_attributeValues;

				describeAccountAttributesResponse_accountAttributeItems.Add(accountAttributeItem);
			}
			describeAccountAttributesResponse.AccountAttributeItems = describeAccountAttributesResponse_accountAttributeItems;
        
			return describeAccountAttributesResponse;
        }
    }
}
