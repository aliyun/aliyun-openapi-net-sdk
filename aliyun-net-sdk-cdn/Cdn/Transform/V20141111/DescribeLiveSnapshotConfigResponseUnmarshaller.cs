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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeLiveSnapshotConfigResponseUnmarshaller
    {
        public static DescribeLiveSnapshotConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveSnapshotConfigResponse describeLiveSnapshotConfigResponse = new DescribeLiveSnapshotConfigResponse();

			describeLiveSnapshotConfigResponse.HttpResponse = context.HttpResponse;
			describeLiveSnapshotConfigResponse.RequestId = context.StringValue("DescribeLiveSnapshotConfig.RequestId");
			describeLiveSnapshotConfigResponse.PageNum = context.IntegerValue("DescribeLiveSnapshotConfig.PageNum");
			describeLiveSnapshotConfigResponse.PageSize = context.IntegerValue("DescribeLiveSnapshotConfig.PageSize");
			describeLiveSnapshotConfigResponse.Order = context.StringValue("DescribeLiveSnapshotConfig.Order");
			describeLiveSnapshotConfigResponse.TotalNum = context.IntegerValue("DescribeLiveSnapshotConfig.TotalNum");
			describeLiveSnapshotConfigResponse.TotalPage = context.IntegerValue("DescribeLiveSnapshotConfig.TotalPage");

			List<DescribeLiveSnapshotConfigResponse.DescribeLiveSnapshotConfig_LiveStreamSnapshotConfig> describeLiveSnapshotConfigResponse_liveStreamSnapshotConfigList = new List<DescribeLiveSnapshotConfigResponse.DescribeLiveSnapshotConfig_LiveStreamSnapshotConfig>();
			for (int i = 0; i < context.Length("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList.Length"); i++) {
				DescribeLiveSnapshotConfigResponse.DescribeLiveSnapshotConfig_LiveStreamSnapshotConfig liveStreamSnapshotConfig = new DescribeLiveSnapshotConfigResponse.DescribeLiveSnapshotConfig_LiveStreamSnapshotConfig();
				liveStreamSnapshotConfig.DomainName = context.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].DomainName");
				liveStreamSnapshotConfig.AppName = context.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].AppName");
				liveStreamSnapshotConfig.TimeInterval = context.IntegerValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].TimeInterval");
				liveStreamSnapshotConfig.OssEndpoint = context.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].OssEndpoint");
				liveStreamSnapshotConfig.OssBucket = context.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].OssBucket");
				liveStreamSnapshotConfig.OverwriteOssObject = context.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].OverwriteOssObject");
				liveStreamSnapshotConfig.SequenceOssObject = context.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].SequenceOssObject");
				liveStreamSnapshotConfig.CreateTime = context.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].CreateTime");

				describeLiveSnapshotConfigResponse_liveStreamSnapshotConfigList.Add(liveStreamSnapshotConfig);
			}
			describeLiveSnapshotConfigResponse.LiveStreamSnapshotConfigList = describeLiveSnapshotConfigResponse_liveStreamSnapshotConfigList;
        
			return describeLiveSnapshotConfigResponse;
        }
    }
}