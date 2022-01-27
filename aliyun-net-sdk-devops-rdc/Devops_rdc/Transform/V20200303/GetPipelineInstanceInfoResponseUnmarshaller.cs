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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class GetPipelineInstanceInfoResponseUnmarshaller
    {
        public static GetPipelineInstanceInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPipelineInstanceInfoResponse getPipelineInstanceInfoResponse = new GetPipelineInstanceInfoResponse();

			getPipelineInstanceInfoResponse.HttpResponse = _ctx.HttpResponse;
			getPipelineInstanceInfoResponse.ErrorMessage = _ctx.StringValue("GetPipelineInstanceInfo.ErrorMessage");
			getPipelineInstanceInfoResponse.RequestId = _ctx.StringValue("GetPipelineInstanceInfo.RequestId");
			getPipelineInstanceInfoResponse.Success = _ctx.BooleanValue("GetPipelineInstanceInfo.Success");
			getPipelineInstanceInfoResponse.ErrorCode = _ctx.StringValue("GetPipelineInstanceInfo.ErrorCode");

			GetPipelineInstanceInfoResponse.GetPipelineInstanceInfo__Object _object = new GetPipelineInstanceInfoResponse.GetPipelineInstanceInfo__Object();
			_object.EmployeeId = _ctx.StringValue("GetPipelineInstanceInfo.Object.EmployeeId");
			_object.EndTime = _ctx.LongValue("GetPipelineInstanceInfo.Object.EndTime");
			_object.Status = _ctx.StringValue("GetPipelineInstanceInfo.Object.Status");
			_object.StartTime = _ctx.LongValue("GetPipelineInstanceInfo.Object.StartTime");
			_object.Sources = _ctx.StringValue("GetPipelineInstanceInfo.Object.Sources");

			List<string> _object_dockerImages = new List<string>();
			for (int i = 0; i < _ctx.Length("GetPipelineInstanceInfo.Object.DockerImages.Length"); i++) {
				_object_dockerImages.Add(_ctx.StringValue("GetPipelineInstanceInfo.Object.DockerImages["+ i +"]"));
			}
			_object.DockerImages = _object_dockerImages;

			List<string> _object_packageDownloadUrls = new List<string>();
			for (int i = 0; i < _ctx.Length("GetPipelineInstanceInfo.Object.PackageDownloadUrls.Length"); i++) {
				_object_packageDownloadUrls.Add(_ctx.StringValue("GetPipelineInstanceInfo.Object.PackageDownloadUrls["+ i +"]"));
			}
			_object.PackageDownloadUrls = _object_packageDownloadUrls;
			getPipelineInstanceInfoResponse._Object = _object;
        
			return getPipelineInstanceInfoResponse;
        }
    }
}
