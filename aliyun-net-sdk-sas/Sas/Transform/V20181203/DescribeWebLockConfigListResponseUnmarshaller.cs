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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeWebLockConfigListResponseUnmarshaller
    {
        public static DescribeWebLockConfigListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWebLockConfigListResponse describeWebLockConfigListResponse = new DescribeWebLockConfigListResponse();

			describeWebLockConfigListResponse.HttpResponse = _ctx.HttpResponse;
			describeWebLockConfigListResponse.RequestId = _ctx.StringValue("DescribeWebLockConfigList.RequestId");
			describeWebLockConfigListResponse.TotalCount = _ctx.IntegerValue("DescribeWebLockConfigList.TotalCount");

			List<DescribeWebLockConfigListResponse.DescribeWebLockConfigList_ConfigInfo> describeWebLockConfigListResponse_configList = new List<DescribeWebLockConfigListResponse.DescribeWebLockConfigList_ConfigInfo>();
			for (int i = 0; i < _ctx.Length("DescribeWebLockConfigList.ConfigList.Length"); i++) {
				DescribeWebLockConfigListResponse.DescribeWebLockConfigList_ConfigInfo configInfo = new DescribeWebLockConfigListResponse.DescribeWebLockConfigList_ConfigInfo();
				configInfo.Id = _ctx.StringValue("DescribeWebLockConfigList.ConfigList["+ i +"].Id");
				configInfo.Uuid = _ctx.StringValue("DescribeWebLockConfigList.ConfigList["+ i +"].Uuid");
				configInfo.Dir = _ctx.StringValue("DescribeWebLockConfigList.ConfigList["+ i +"].Dir");
				configInfo.ExclusiveDir = _ctx.StringValue("DescribeWebLockConfigList.ConfigList["+ i +"].ExclusiveDir");
				configInfo.ExclusiveFileType = _ctx.StringValue("DescribeWebLockConfigList.ConfigList["+ i +"].ExclusiveFileType");
				configInfo.LocalBackupDir = _ctx.StringValue("DescribeWebLockConfigList.ConfigList["+ i +"].LocalBackupDir");
				configInfo.Mode = _ctx.StringValue("DescribeWebLockConfigList.ConfigList["+ i +"].Mode");
				configInfo.InclusiveFileType = _ctx.StringValue("DescribeWebLockConfigList.ConfigList["+ i +"].InclusiveFileType");
				configInfo.ExclusiveFile = _ctx.StringValue("DescribeWebLockConfigList.ConfigList["+ i +"].ExclusiveFile");
				configInfo.InclusiveFile = _ctx.StringValue("DescribeWebLockConfigList.ConfigList["+ i +"].InclusiveFile");
				configInfo.DefenceMode = _ctx.StringValue("DescribeWebLockConfigList.ConfigList["+ i +"].DefenceMode");

				describeWebLockConfigListResponse_configList.Add(configInfo);
			}
			describeWebLockConfigListResponse.ConfigList = describeWebLockConfigListResponse_configList;
        
			return describeWebLockConfigListResponse;
        }
    }
}
