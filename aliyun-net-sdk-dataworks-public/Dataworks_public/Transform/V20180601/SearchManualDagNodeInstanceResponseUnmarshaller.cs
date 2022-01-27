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
using Aliyun.Acs.dataworks_public.Model.V20180601;

namespace Aliyun.Acs.dataworks_public.Transform.V20180601
{
    public class SearchManualDagNodeInstanceResponseUnmarshaller
    {
        public static SearchManualDagNodeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchManualDagNodeInstanceResponse searchManualDagNodeInstanceResponse = new SearchManualDagNodeInstanceResponse();

			searchManualDagNodeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			searchManualDagNodeInstanceResponse.RequestId = _ctx.StringValue("SearchManualDagNodeInstance.RequestId");
			searchManualDagNodeInstanceResponse.ErrCode = _ctx.StringValue("SearchManualDagNodeInstance.ErrCode");
			searchManualDagNodeInstanceResponse.ErrMsg = _ctx.StringValue("SearchManualDagNodeInstance.ErrMsg");
			searchManualDagNodeInstanceResponse.Success = _ctx.BooleanValue("SearchManualDagNodeInstance.Success");

			List<SearchManualDagNodeInstanceResponse.SearchManualDagNodeInstance_NodeInsInfo> searchManualDagNodeInstanceResponse_data = new List<SearchManualDagNodeInstanceResponse.SearchManualDagNodeInstance_NodeInsInfo>();
			for (int i = 0; i < _ctx.Length("SearchManualDagNodeInstance.Data.Length"); i++) {
				SearchManualDagNodeInstanceResponse.SearchManualDagNodeInstance_NodeInsInfo nodeInsInfo = new SearchManualDagNodeInstanceResponse.SearchManualDagNodeInstance_NodeInsInfo();
				nodeInsInfo.InstanceId = _ctx.LongValue("SearchManualDagNodeInstance.Data["+ i +"].InstanceId");
				nodeInsInfo.DagId = _ctx.LongValue("SearchManualDagNodeInstance.Data["+ i +"].DagId");
				nodeInsInfo.DagType = _ctx.IntegerValue("SearchManualDagNodeInstance.Data["+ i +"].DagType");
				nodeInsInfo.Status = _ctx.IntegerValue("SearchManualDagNodeInstance.Data["+ i +"].Status");
				nodeInsInfo.Bizdate = _ctx.StringValue("SearchManualDagNodeInstance.Data["+ i +"].Bizdate");
				nodeInsInfo.ParaValue = _ctx.StringValue("SearchManualDagNodeInstance.Data["+ i +"].ParaValue");
				nodeInsInfo.FinishTime = _ctx.StringValue("SearchManualDagNodeInstance.Data["+ i +"].FinishTime");
				nodeInsInfo.BeginWaitTimeTime = _ctx.StringValue("SearchManualDagNodeInstance.Data["+ i +"].BeginWaitTimeTime");
				nodeInsInfo.BeginWaitResTime = _ctx.StringValue("SearchManualDagNodeInstance.Data["+ i +"].BeginWaitResTime");
				nodeInsInfo.BeginRunningTime = _ctx.StringValue("SearchManualDagNodeInstance.Data["+ i +"].BeginRunningTime");
				nodeInsInfo.CreateTime = _ctx.StringValue("SearchManualDagNodeInstance.Data["+ i +"].CreateTime");
				nodeInsInfo.ModifyTime = _ctx.StringValue("SearchManualDagNodeInstance.Data["+ i +"].ModifyTime");
				nodeInsInfo.NodeName = _ctx.StringValue("SearchManualDagNodeInstance.Data["+ i +"].NodeName");

				searchManualDagNodeInstanceResponse_data.Add(nodeInsInfo);
			}
			searchManualDagNodeInstanceResponse.Data = searchManualDagNodeInstanceResponse_data;
        
			return searchManualDagNodeInstanceResponse;
        }
    }
}
