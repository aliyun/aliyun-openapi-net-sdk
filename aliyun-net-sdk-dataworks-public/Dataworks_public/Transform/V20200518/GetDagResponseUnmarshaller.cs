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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetDagResponseUnmarshaller
    {
        public static GetDagResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDagResponse getDagResponse = new GetDagResponse();

			getDagResponse.HttpResponse = _ctx.HttpResponse;
			getDagResponse.Success = _ctx.BooleanValue("GetDag.Success");
			getDagResponse.HttpStatusCode = _ctx.IntegerValue("GetDag.HttpStatusCode");
			getDagResponse.ErrorCode = _ctx.StringValue("GetDag.ErrorCode");
			getDagResponse.ErrorMessage = _ctx.StringValue("GetDag.ErrorMessage");
			getDagResponse.RequestId = _ctx.StringValue("GetDag.RequestId");

			GetDagResponse.GetDag_Data data = new GetDagResponse.GetDag_Data();
			data.ProjectId = _ctx.LongValue("GetDag.Data.ProjectId");
			data.DagId = _ctx.LongValue("GetDag.Data.DagId");
			data.Name = _ctx.StringValue("GetDag.Data.Name");
			data.Type = _ctx.StringValue("GetDag.Data.Type");
			data.Status = _ctx.StringValue("GetDag.Data.Status");
			data.Bizdate = _ctx.LongValue("GetDag.Data.Bizdate");
			data.Gmtdate = _ctx.LongValue("GetDag.Data.Gmtdate");
			data.StartTime = _ctx.LongValue("GetDag.Data.StartTime");
			data.FinishTime = _ctx.LongValue("GetDag.Data.FinishTime");
			data.CreateTime = _ctx.LongValue("GetDag.Data.CreateTime");
			data.CreateUser = _ctx.StringValue("GetDag.Data.CreateUser");
			data.ModifyTime = _ctx.LongValue("GetDag.Data.ModifyTime");
			getDagResponse.Data = data;
        
			return getDagResponse;
        }
    }
}
