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
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeModelsResponseUnmarshaller
    {
        public static DescribeModelsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeModelsResponse describeModelsResponse = new DescribeModelsResponse();

			describeModelsResponse.HttpResponse = context.HttpResponse;
			describeModelsResponse.RequestId = context.StringValue("DescribeModels.RequestId");
			describeModelsResponse.TotalCount = context.IntegerValue("DescribeModels.TotalCount");
			describeModelsResponse.PageSize = context.IntegerValue("DescribeModels.PageSize");
			describeModelsResponse.PageNumber = context.IntegerValue("DescribeModels.PageNumber");

			List<DescribeModelsResponse.DescribeModels_ModelDetail> describeModelsResponse_modelDetails = new List<DescribeModelsResponse.DescribeModels_ModelDetail>();
			for (int i = 0; i < context.Length("DescribeModels.ModelDetails.Length"); i++) {
				DescribeModelsResponse.DescribeModels_ModelDetail modelDetail = new DescribeModelsResponse.DescribeModels_ModelDetail();
				modelDetail.GroupId = context.StringValue("DescribeModels.ModelDetails["+ i +"].GroupId");
				modelDetail.ModelId = context.StringValue("DescribeModels.ModelDetails["+ i +"].ModelId");
				modelDetail.ModelName = context.StringValue("DescribeModels.ModelDetails["+ i +"].ModelName");
				modelDetail.Schema = context.StringValue("DescribeModels.ModelDetails["+ i +"].Schema");
				modelDetail.Description = context.StringValue("DescribeModels.ModelDetails["+ i +"].Description");
				modelDetail.CreatedTime = context.StringValue("DescribeModels.ModelDetails["+ i +"].CreatedTime");
				modelDetail.ModifiedTime = context.StringValue("DescribeModels.ModelDetails["+ i +"].ModifiedTime");
				modelDetail.ModelRef = context.StringValue("DescribeModels.ModelDetails["+ i +"].ModelRef");

				describeModelsResponse_modelDetails.Add(modelDetail);
			}
			describeModelsResponse.ModelDetails = describeModelsResponse_modelDetails;
        
			return describeModelsResponse;
        }
    }
}