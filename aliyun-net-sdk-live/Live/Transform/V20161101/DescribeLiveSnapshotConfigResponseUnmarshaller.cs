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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveSnapshotConfigResponseUnmarshaller
    {
        public static DescribeLiveSnapshotConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveSnapshotConfigResponse describeLiveSnapshotConfigResponse = new DescribeLiveSnapshotConfigResponse();

			describeLiveSnapshotConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveSnapshotConfigResponse.RequestId = _ctx.StringValue("DescribeLiveSnapshotConfig.RequestId");
			describeLiveSnapshotConfigResponse.PageNum = _ctx.IntegerValue("DescribeLiveSnapshotConfig.PageNum");
			describeLiveSnapshotConfigResponse.PageSize = _ctx.IntegerValue("DescribeLiveSnapshotConfig.PageSize");
			describeLiveSnapshotConfigResponse.Order = _ctx.StringValue("DescribeLiveSnapshotConfig.Order");
			describeLiveSnapshotConfigResponse.TotalNum = _ctx.IntegerValue("DescribeLiveSnapshotConfig.TotalNum");
			describeLiveSnapshotConfigResponse.TotalPage = _ctx.IntegerValue("DescribeLiveSnapshotConfig.TotalPage");

			List<DescribeLiveSnapshotConfigResponse.DescribeLiveSnapshotConfig_LiveStreamSnapshotConfig> describeLiveSnapshotConfigResponse_liveStreamSnapshotConfigList = new List<DescribeLiveSnapshotConfigResponse.DescribeLiveSnapshotConfig_LiveStreamSnapshotConfig>();
			for (int i = 0; i < _ctx.Length("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList.Length"); i++) {
				DescribeLiveSnapshotConfigResponse.DescribeLiveSnapshotConfig_LiveStreamSnapshotConfig liveStreamSnapshotConfig = new DescribeLiveSnapshotConfigResponse.DescribeLiveSnapshotConfig_LiveStreamSnapshotConfig();
				liveStreamSnapshotConfig.DomainName = _ctx.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].DomainName");
				liveStreamSnapshotConfig.AppName = _ctx.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].AppName");
				liveStreamSnapshotConfig.TimeInterval = _ctx.IntegerValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].TimeInterval");
				liveStreamSnapshotConfig.OssEndpoint = _ctx.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].OssEndpoint");
				liveStreamSnapshotConfig.OssBucket = _ctx.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].OssBucket");
				liveStreamSnapshotConfig.OverwriteOssObject = _ctx.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].OverwriteOssObject");
				liveStreamSnapshotConfig.SequenceOssObject = _ctx.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].SequenceOssObject");
				liveStreamSnapshotConfig.CreateTime = _ctx.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].CreateTime");
				liveStreamSnapshotConfig.Callback = _ctx.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].Callback");

				describeLiveSnapshotConfigResponse_liveStreamSnapshotConfigList.Add(liveStreamSnapshotConfig);
			}
			describeLiveSnapshotConfigResponse.LiveStreamSnapshotConfigList = describeLiveSnapshotConfigResponse_liveStreamSnapshotConfigList;
        
			return describeLiveSnapshotConfigResponse;
        }
    }
}
