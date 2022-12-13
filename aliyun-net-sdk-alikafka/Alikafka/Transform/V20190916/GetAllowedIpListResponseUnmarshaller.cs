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
using Aliyun.Acs.alikafka.Model.V20190916;

namespace Aliyun.Acs.alikafka.Transform.V20190916
{
    public class GetAllowedIpListResponseUnmarshaller
    {
        public static GetAllowedIpListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAllowedIpListResponse getAllowedIpListResponse = new GetAllowedIpListResponse();

			getAllowedIpListResponse.HttpResponse = _ctx.HttpResponse;
			getAllowedIpListResponse.Code = _ctx.IntegerValue("GetAllowedIpList.Code");
			getAllowedIpListResponse.Message = _ctx.StringValue("GetAllowedIpList.Message");
			getAllowedIpListResponse.RequestId = _ctx.StringValue("GetAllowedIpList.RequestId");
			getAllowedIpListResponse.Success = _ctx.BooleanValue("GetAllowedIpList.Success");

			GetAllowedIpListResponse.GetAllowedIpList_AllowedList allowedList = new GetAllowedIpListResponse.GetAllowedIpList_AllowedList();
			allowedList.DeployType = _ctx.IntegerValue("GetAllowedIpList.AllowedList.DeployType");

			List<GetAllowedIpListResponse.GetAllowedIpList_AllowedList.GetAllowedIpList_IPListVO> allowedList_vpcList = new List<GetAllowedIpListResponse.GetAllowedIpList_AllowedList.GetAllowedIpList_IPListVO>();
			for (int i = 0; i < _ctx.Length("GetAllowedIpList.AllowedList.VpcList.Length"); i++) {
				GetAllowedIpListResponse.GetAllowedIpList_AllowedList.GetAllowedIpList_IPListVO iPListVO = new GetAllowedIpListResponse.GetAllowedIpList_AllowedList.GetAllowedIpList_IPListVO();
				iPListVO.PortRange = _ctx.StringValue("GetAllowedIpList.AllowedList.VpcList["+ i +"].PortRange");
				iPListVO.AllowedIpGroup = _ctx.StringValue("GetAllowedIpList.AllowedList.VpcList["+ i +"].AllowedIpGroup");

				List<string> iPListVO_allowedIpList = new List<string>();
				for (int j = 0; j < _ctx.Length("GetAllowedIpList.AllowedList.VpcList["+ i +"].AllowedIpList.Length"); j++) {
					iPListVO_allowedIpList.Add(_ctx.StringValue("GetAllowedIpList.AllowedList.VpcList["+ i +"].AllowedIpList["+ j +"]"));
				}
				iPListVO.AllowedIpList = iPListVO_allowedIpList;

				allowedList_vpcList.Add(iPListVO);
			}
			allowedList.VpcList = allowedList_vpcList;

			List<GetAllowedIpListResponse.GetAllowedIpList_AllowedList.GetAllowedIpList_IPListVO> allowedList_internetList = new List<GetAllowedIpListResponse.GetAllowedIpList_AllowedList.GetAllowedIpList_IPListVO>();
			for (int i = 0; i < _ctx.Length("GetAllowedIpList.AllowedList.InternetList.Length"); i++) {
				GetAllowedIpListResponse.GetAllowedIpList_AllowedList.GetAllowedIpList_IPListVO iPListVO = new GetAllowedIpListResponse.GetAllowedIpList_AllowedList.GetAllowedIpList_IPListVO();
				iPListVO.PortRange = _ctx.StringValue("GetAllowedIpList.AllowedList.InternetList["+ i +"].PortRange");
				iPListVO.AllowedIpGroup = _ctx.StringValue("GetAllowedIpList.AllowedList.InternetList["+ i +"].AllowedIpGroup");

				List<string> iPListVO_allowedIpList = new List<string>();
				for (int j = 0; j < _ctx.Length("GetAllowedIpList.AllowedList.InternetList["+ i +"].AllowedIpList.Length"); j++) {
					iPListVO_allowedIpList.Add(_ctx.StringValue("GetAllowedIpList.AllowedList.InternetList["+ i +"].AllowedIpList["+ j +"]"));
				}
				iPListVO.AllowedIpList = iPListVO_allowedIpList;

				allowedList_internetList.Add(iPListVO);
			}
			allowedList.InternetList = allowedList_internetList;
			getAllowedIpListResponse.AllowedList = allowedList;
        
			return getAllowedIpListResponse;
        }
    }
}
