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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeRecycleBinResponseUnmarshaller
    {
        public static DescribeRecycleBinResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRecycleBinResponse describeRecycleBinResponse = new DescribeRecycleBinResponse();

			describeRecycleBinResponse.HttpResponse = context.HttpResponse;
			describeRecycleBinResponse.RequestId = context.StringValue("DescribeRecycleBin.RequestId");
			describeRecycleBinResponse.TotalCount = context.IntegerValue("DescribeRecycleBin.TotalCount");

			List<DescribeRecycleBinResponse.DescribeRecycleBin_RecycleBinModel> describeRecycleBinResponse_recycleBinModels = new List<DescribeRecycleBinResponse.DescribeRecycleBin_RecycleBinModel>();
			for (int i = 0; i < context.Length("DescribeRecycleBin.RecycleBinModels.Length"); i++) {
				DescribeRecycleBinResponse.DescribeRecycleBin_RecycleBinModel recycleBinModel = new DescribeRecycleBinResponse.DescribeRecycleBin_RecycleBinModel();
				recycleBinModel.ResourceId = context.StringValue("DescribeRecycleBin.RecycleBinModels["+ i +"].ResourceId");
				recycleBinModel.RegionId = context.StringValue("DescribeRecycleBin.RecycleBinModels["+ i +"].RegionId");
				recycleBinModel.ResourceType = context.StringValue("DescribeRecycleBin.RecycleBinModels["+ i +"].ResourceType");
				recycleBinModel.CreationTime = context.StringValue("DescribeRecycleBin.RecycleBinModels["+ i +"].CreationTime");
				recycleBinModel.Status = context.StringValue("DescribeRecycleBin.RecycleBinModels["+ i +"].Status");

				List<DescribeRecycleBinResponse.DescribeRecycleBin_RecycleBinModel.DescribeRecycleBin_RelationResource> recycleBinModel_relationResources = new List<DescribeRecycleBinResponse.DescribeRecycleBin_RecycleBinModel.DescribeRecycleBin_RelationResource>();
				for (int j = 0; j < context.Length("DescribeRecycleBin.RecycleBinModels["+ i +"].RelationResources.Length"); j++) {
					DescribeRecycleBinResponse.DescribeRecycleBin_RecycleBinModel.DescribeRecycleBin_RelationResource relationResource = new DescribeRecycleBinResponse.DescribeRecycleBin_RecycleBinModel.DescribeRecycleBin_RelationResource();
					relationResource.RelationResourceId = context.StringValue("DescribeRecycleBin.RecycleBinModels["+ i +"].RelationResources["+ j +"].RelationResourceId");
					relationResource.RelationResourceType = context.StringValue("DescribeRecycleBin.RecycleBinModels["+ i +"].RelationResources["+ j +"].RelationResourceType");

					recycleBinModel_relationResources.Add(relationResource);
				}
				recycleBinModel.RelationResources = recycleBinModel_relationResources;

				describeRecycleBinResponse_recycleBinModels.Add(recycleBinModel);
			}
			describeRecycleBinResponse.RecycleBinModels = describeRecycleBinResponse_recycleBinModels;
        
			return describeRecycleBinResponse;
        }
    }
}