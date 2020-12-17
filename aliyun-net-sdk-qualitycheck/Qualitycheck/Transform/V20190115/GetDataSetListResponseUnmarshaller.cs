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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class GetDataSetListResponseUnmarshaller
    {
        public static GetDataSetListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDataSetListResponse getDataSetListResponse = new GetDataSetListResponse();

			getDataSetListResponse.HttpResponse = _ctx.HttpResponse;
			getDataSetListResponse.RequestId = _ctx.StringValue("GetDataSetList.RequestId");
			getDataSetListResponse.Success = _ctx.BooleanValue("GetDataSetList.Success");
			getDataSetListResponse.Code = _ctx.StringValue("GetDataSetList.Code");
			getDataSetListResponse.Message = _ctx.StringValue("GetDataSetList.Message");
			getDataSetListResponse.Count = _ctx.IntegerValue("GetDataSetList.Count");

			List<GetDataSetListResponse.GetDataSetList_DataSet> getDataSetListResponse_data = new List<GetDataSetListResponse.GetDataSetList_DataSet>();
			for (int i = 0; i < _ctx.Length("GetDataSetList.Data.Length"); i++) {
				GetDataSetListResponse.GetDataSetList_DataSet dataSet = new GetDataSetListResponse.GetDataSetList_DataSet();
				dataSet.SetId = _ctx.LongValue("GetDataSetList.Data["+ i +"].SetId");
				dataSet.SetName = _ctx.StringValue("GetDataSetList.Data["+ i +"].SetName");
				dataSet.SetDomain = _ctx.StringValue("GetDataSetList.Data["+ i +"].SetDomain");
				dataSet.SetRoleArn = _ctx.StringValue("GetDataSetList.Data["+ i +"].SetRoleArn");
				dataSet.SetBucketName = _ctx.StringValue("GetDataSetList.Data["+ i +"].SetBucketName");
				dataSet.SetFolderName = _ctx.StringValue("GetDataSetList.Data["+ i +"].SetFolderName");
				dataSet.ChannelType = _ctx.IntegerValue("GetDataSetList.Data["+ i +"].ChannelType");
				dataSet.CreateType = _ctx.IntegerValue("GetDataSetList.Data["+ i +"].CreateType");
				dataSet.CreateTime = _ctx.StringValue("GetDataSetList.Data["+ i +"].CreateTime");
				dataSet.UpdateTime = _ctx.StringValue("GetDataSetList.Data["+ i +"].UpdateTime");
				dataSet.SetNumber = _ctx.IntegerValue("GetDataSetList.Data["+ i +"].SetNumber");

				getDataSetListResponse_data.Add(dataSet);
			}
			getDataSetListResponse.Data = getDataSetListResponse_data;
        
			return getDataSetListResponse;
        }
    }
}
