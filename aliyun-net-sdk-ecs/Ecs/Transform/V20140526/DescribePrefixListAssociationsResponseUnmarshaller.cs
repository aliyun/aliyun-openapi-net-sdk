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
    public class DescribePrefixListAssociationsResponseUnmarshaller
    {
        public static DescribePrefixListAssociationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePrefixListAssociationsResponse describePrefixListAssociationsResponse = new DescribePrefixListAssociationsResponse();

			describePrefixListAssociationsResponse.HttpResponse = _ctx.HttpResponse;
			describePrefixListAssociationsResponse.RequestId = _ctx.StringValue("DescribePrefixListAssociations.RequestId");
			describePrefixListAssociationsResponse.NextToken = _ctx.StringValue("DescribePrefixListAssociations.NextToken");

			List<DescribePrefixListAssociationsResponse.DescribePrefixListAssociations_PrefixListAssociation> describePrefixListAssociationsResponse_prefixListAssociations = new List<DescribePrefixListAssociationsResponse.DescribePrefixListAssociations_PrefixListAssociation>();
			for (int i = 0; i < _ctx.Length("DescribePrefixListAssociations.PrefixListAssociations.Length"); i++) {
				DescribePrefixListAssociationsResponse.DescribePrefixListAssociations_PrefixListAssociation prefixListAssociation = new DescribePrefixListAssociationsResponse.DescribePrefixListAssociations_PrefixListAssociation();
				prefixListAssociation.ResourceId = _ctx.StringValue("DescribePrefixListAssociations.PrefixListAssociations["+ i +"].ResourceId");
				prefixListAssociation.ResourceType = _ctx.StringValue("DescribePrefixListAssociations.PrefixListAssociations["+ i +"].ResourceType");

				describePrefixListAssociationsResponse_prefixListAssociations.Add(prefixListAssociation);
			}
			describePrefixListAssociationsResponse.PrefixListAssociations = describePrefixListAssociationsResponse_prefixListAssociations;
        
			return describePrefixListAssociationsResponse;
        }
    }
}
