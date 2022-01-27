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
    public class DescribeNoticeConfigResponseUnmarshaller
    {
        public static DescribeNoticeConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNoticeConfigResponse describeNoticeConfigResponse = new DescribeNoticeConfigResponse();

			describeNoticeConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeNoticeConfigResponse.RequestId = _ctx.StringValue("DescribeNoticeConfig.RequestId");

			List<DescribeNoticeConfigResponse.DescribeNoticeConfig_NoticeConfig> describeNoticeConfigResponse_noticeConfigList = new List<DescribeNoticeConfigResponse.DescribeNoticeConfig_NoticeConfig>();
			for (int i = 0; i < _ctx.Length("DescribeNoticeConfig.NoticeConfigList.Length"); i++) {
				DescribeNoticeConfigResponse.DescribeNoticeConfig_NoticeConfig noticeConfig = new DescribeNoticeConfigResponse.DescribeNoticeConfig_NoticeConfig();
				noticeConfig.TimeLimit = _ctx.IntegerValue("DescribeNoticeConfig.NoticeConfigList["+ i +"].TimeLimit");
				noticeConfig.Route = _ctx.IntegerValue("DescribeNoticeConfig.NoticeConfigList["+ i +"].Route");
				noticeConfig.Project = _ctx.StringValue("DescribeNoticeConfig.NoticeConfigList["+ i +"].Project");
				noticeConfig.AliUid = _ctx.LongValue("DescribeNoticeConfig.NoticeConfigList["+ i +"].AliUid");
				noticeConfig.CurrentPage = _ctx.IntegerValue("DescribeNoticeConfig.NoticeConfigList["+ i +"].CurrentPage");

				describeNoticeConfigResponse_noticeConfigList.Add(noticeConfig);
			}
			describeNoticeConfigResponse.NoticeConfigList = describeNoticeConfigResponse_noticeConfigList;
        
			return describeNoticeConfigResponse;
        }
    }
}
