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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeEcGrantRelationResponseUnmarshaller
    {
        public static DescribeEcGrantRelationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEcGrantRelationResponse describeEcGrantRelationResponse = new DescribeEcGrantRelationResponse();

			describeEcGrantRelationResponse.HttpResponse = _ctx.HttpResponse;
			describeEcGrantRelationResponse.RequestId = _ctx.StringValue("DescribeEcGrantRelation.RequestId");
			describeEcGrantRelationResponse.TotalCount = _ctx.IntegerValue("DescribeEcGrantRelation.TotalCount");
			describeEcGrantRelationResponse.Count = _ctx.IntegerValue("DescribeEcGrantRelation.Count");
			describeEcGrantRelationResponse.Page = _ctx.IntegerValue("DescribeEcGrantRelation.Page");
			describeEcGrantRelationResponse.PageSize = _ctx.IntegerValue("DescribeEcGrantRelation.PageSize");

			List<DescribeEcGrantRelationResponse.DescribeEcGrantRelation_EcGrantRelationModel> describeEcGrantRelationResponse_ecGrantRelations = new List<DescribeEcGrantRelationResponse.DescribeEcGrantRelation_EcGrantRelationModel>();
			for (int i = 0; i < _ctx.Length("DescribeEcGrantRelation.EcGrantRelations.Length"); i++) {
				DescribeEcGrantRelationResponse.DescribeEcGrantRelation_EcGrantRelationModel ecGrantRelationModel = new DescribeEcGrantRelationResponse.DescribeEcGrantRelation_EcGrantRelationModel();
				ecGrantRelationModel.VbrOwnerUid = _ctx.LongValue("DescribeEcGrantRelation.EcGrantRelations["+ i +"].VbrOwnerUid");
				ecGrantRelationModel.VbrInstanceId = _ctx.StringValue("DescribeEcGrantRelation.EcGrantRelations["+ i +"].VbrInstanceId");
				ecGrantRelationModel.InstanceId = _ctx.StringValue("DescribeEcGrantRelation.EcGrantRelations["+ i +"].InstanceId");
				ecGrantRelationModel.AliUid = _ctx.LongValue("DescribeEcGrantRelation.EcGrantRelations["+ i +"].AliUid");
				ecGrantRelationModel.RegionNo = _ctx.StringValue("DescribeEcGrantRelation.EcGrantRelations["+ i +"].RegionNo");
				ecGrantRelationModel.Status = _ctx.StringValue("DescribeEcGrantRelation.EcGrantRelations["+ i +"].Status");
				ecGrantRelationModel.InstanceName = _ctx.StringValue("DescribeEcGrantRelation.EcGrantRelations["+ i +"].InstanceName");
				ecGrantRelationModel.InstanceRouterId = _ctx.StringValue("DescribeEcGrantRelation.EcGrantRelations["+ i +"].InstanceRouterId");
				ecGrantRelationModel.VbrRegionNo = _ctx.StringValue("DescribeEcGrantRelation.EcGrantRelations["+ i +"].VbrRegionNo");
				ecGrantRelationModel.GmtCreate = _ctx.StringValue("DescribeEcGrantRelation.EcGrantRelations["+ i +"].GmtCreate");

				describeEcGrantRelationResponse_ecGrantRelations.Add(ecGrantRelationModel);
			}
			describeEcGrantRelationResponse.EcGrantRelations = describeEcGrantRelationResponse_ecGrantRelations;
        
			return describeEcGrantRelationResponse;
        }
    }
}
