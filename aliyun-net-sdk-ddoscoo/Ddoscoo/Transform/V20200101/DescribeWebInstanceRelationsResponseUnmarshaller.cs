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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeWebInstanceRelationsResponseUnmarshaller
    {
        public static DescribeWebInstanceRelationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWebInstanceRelationsResponse describeWebInstanceRelationsResponse = new DescribeWebInstanceRelationsResponse();

			describeWebInstanceRelationsResponse.HttpResponse = _ctx.HttpResponse;
			describeWebInstanceRelationsResponse.RequestId = _ctx.StringValue("DescribeWebInstanceRelations.RequestId");

			List<DescribeWebInstanceRelationsResponse.DescribeWebInstanceRelations_WebInstanceRelation> describeWebInstanceRelationsResponse_webInstanceRelations = new List<DescribeWebInstanceRelationsResponse.DescribeWebInstanceRelations_WebInstanceRelation>();
			for (int i = 0; i < _ctx.Length("DescribeWebInstanceRelations.WebInstanceRelations.Length"); i++) {
				DescribeWebInstanceRelationsResponse.DescribeWebInstanceRelations_WebInstanceRelation webInstanceRelation = new DescribeWebInstanceRelationsResponse.DescribeWebInstanceRelations_WebInstanceRelation();
				webInstanceRelation.Domain = _ctx.StringValue("DescribeWebInstanceRelations.WebInstanceRelations["+ i +"].Domain");

				List<DescribeWebInstanceRelationsResponse.DescribeWebInstanceRelations_WebInstanceRelation.DescribeWebInstanceRelations_InstanceDetail> webInstanceRelation_instanceDetails = new List<DescribeWebInstanceRelationsResponse.DescribeWebInstanceRelations_WebInstanceRelation.DescribeWebInstanceRelations_InstanceDetail>();
				for (int j = 0; j < _ctx.Length("DescribeWebInstanceRelations.WebInstanceRelations["+ i +"].InstanceDetails.Length"); j++) {
					DescribeWebInstanceRelationsResponse.DescribeWebInstanceRelations_WebInstanceRelation.DescribeWebInstanceRelations_InstanceDetail instanceDetail = new DescribeWebInstanceRelationsResponse.DescribeWebInstanceRelations_WebInstanceRelation.DescribeWebInstanceRelations_InstanceDetail();
					instanceDetail.InstanceId = _ctx.StringValue("DescribeWebInstanceRelations.WebInstanceRelations["+ i +"].InstanceDetails["+ j +"].InstanceId");
					instanceDetail.FunctionVersion = _ctx.StringValue("DescribeWebInstanceRelations.WebInstanceRelations["+ i +"].InstanceDetails["+ j +"].FunctionVersion");

					List<string> instanceDetail_eipList = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeWebInstanceRelations.WebInstanceRelations["+ i +"].InstanceDetails["+ j +"].EipList.Length"); k++) {
						instanceDetail_eipList.Add(_ctx.StringValue("DescribeWebInstanceRelations.WebInstanceRelations["+ i +"].InstanceDetails["+ j +"].EipList["+ k +"]"));
					}
					instanceDetail.EipList = instanceDetail_eipList;

					webInstanceRelation_instanceDetails.Add(instanceDetail);
				}
				webInstanceRelation.InstanceDetails = webInstanceRelation_instanceDetails;

				describeWebInstanceRelationsResponse_webInstanceRelations.Add(webInstanceRelation);
			}
			describeWebInstanceRelationsResponse.WebInstanceRelations = describeWebInstanceRelationsResponse_webInstanceRelations;
        
			return describeWebInstanceRelationsResponse;
        }
    }
}
