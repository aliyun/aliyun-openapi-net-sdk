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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListLocalDiskComponentInfoResponseUnmarshaller
    {
        public static ListLocalDiskComponentInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLocalDiskComponentInfoResponse listLocalDiskComponentInfoResponse = new ListLocalDiskComponentInfoResponse();

			listLocalDiskComponentInfoResponse.HttpResponse = _ctx.HttpResponse;
			listLocalDiskComponentInfoResponse.RequestId = _ctx.StringValue("ListLocalDiskComponentInfo.RequestId");

			List<ListLocalDiskComponentInfoResponse.ListLocalDiskComponentInfo_ComponentInfo> listLocalDiskComponentInfoResponse_componentInfoList = new List<ListLocalDiskComponentInfoResponse.ListLocalDiskComponentInfo_ComponentInfo>();
			for (int i = 0; i < _ctx.Length("ListLocalDiskComponentInfo.ComponentInfoList.Length"); i++) {
				ListLocalDiskComponentInfoResponse.ListLocalDiskComponentInfo_ComponentInfo componentInfo = new ListLocalDiskComponentInfoResponse.ListLocalDiskComponentInfo_ComponentInfo();
				componentInfo.ServiceName = _ctx.StringValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].ServiceName");
				componentInfo.ServiceDisplayName = _ctx.StringValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].ServiceDisplayName");
				componentInfo.ComponentName = _ctx.StringValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].ComponentName");
				componentInfo.ComponentDisplayName = _ctx.StringValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].ComponentDisplayName");
				componentInfo.IsolateWarningMsg = _ctx.StringValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].IsolateWarningMsg");
				componentInfo.MountWarningMsg = _ctx.StringValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].MountWarningMsg");
				componentInfo.RebootWarningMsg = _ctx.StringValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].RebootWarningMsg");
				componentInfo.SupportDiskHotSwap = _ctx.BooleanValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].SupportDiskHotSwap");

				List<string> componentInfo_apmMetrics = new List<string>();
				for (int j = 0; j < _ctx.Length("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].ApmMetrics.Length"); j++) {
					componentInfo_apmMetrics.Add(_ctx.StringValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].ApmMetrics["+ j +"]"));
				}
				componentInfo.ApmMetrics = componentInfo_apmMetrics;

				List<ListLocalDiskComponentInfoResponse.ListLocalDiskComponentInfo_ComponentInfo.ListLocalDiskComponentInfo_MountParam> componentInfo_mountParams = new List<ListLocalDiskComponentInfoResponse.ListLocalDiskComponentInfo_ComponentInfo.ListLocalDiskComponentInfo_MountParam>();
				for (int j = 0; j < _ctx.Length("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].MountParams.Length"); j++) {
					ListLocalDiskComponentInfoResponse.ListLocalDiskComponentInfo_ComponentInfo.ListLocalDiskComponentInfo_MountParam mountParam = new ListLocalDiskComponentInfoResponse.ListLocalDiskComponentInfo_ComponentInfo.ListLocalDiskComponentInfo_MountParam();
					mountParam.Name = _ctx.StringValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].MountParams["+ j +"].Name");
					mountParam.Key = _ctx.StringValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].MountParams["+ j +"].Key");
					mountParam.ValueType = _ctx.StringValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].MountParams["+ j +"].ValueType");
					mountParam.DefaultValue = _ctx.StringValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].MountParams["+ j +"].DefaultValue");
					mountParam.Tips = _ctx.StringValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].MountParams["+ j +"].Tips");
					mountParam.Unit = _ctx.StringValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].MountParams["+ j +"].Unit");
					mountParam.Min = _ctx.IntegerValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].MountParams["+ j +"].Min");
					mountParam.Max = _ctx.IntegerValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].MountParams["+ j +"].Max");

					List<string> mountParam_options = new List<string>();
					for (int k = 0; k < _ctx.Length("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].MountParams["+ j +"].Options.Length"); k++) {
						mountParam_options.Add(_ctx.StringValue("ListLocalDiskComponentInfo.ComponentInfoList["+ i +"].MountParams["+ j +"].Options["+ k +"]"));
					}
					mountParam.Options = mountParam_options;

					componentInfo_mountParams.Add(mountParam);
				}
				componentInfo.MountParams = componentInfo_mountParams;

				listLocalDiskComponentInfoResponse_componentInfoList.Add(componentInfo);
			}
			listLocalDiskComponentInfoResponse.ComponentInfoList = listLocalDiskComponentInfoResponse_componentInfoList;
        
			return listLocalDiskComponentInfoResponse;
        }
    }
}
