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
    public class DescribeLiveSnapshotDetectPornConfigResponseUnmarshaller
    {
        public static DescribeLiveSnapshotDetectPornConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveSnapshotDetectPornConfigResponse describeLiveSnapshotDetectPornConfigResponse = new DescribeLiveSnapshotDetectPornConfigResponse();

			describeLiveSnapshotDetectPornConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveSnapshotDetectPornConfigResponse.RequestId = _ctx.StringValue("DescribeLiveSnapshotDetectPornConfig.RequestId");
			describeLiveSnapshotDetectPornConfigResponse.PageNum = _ctx.IntegerValue("DescribeLiveSnapshotDetectPornConfig.PageNum");
			describeLiveSnapshotDetectPornConfigResponse.PageSize = _ctx.IntegerValue("DescribeLiveSnapshotDetectPornConfig.PageSize");
			describeLiveSnapshotDetectPornConfigResponse.Order = _ctx.StringValue("DescribeLiveSnapshotDetectPornConfig.Order");
			describeLiveSnapshotDetectPornConfigResponse.TotalNum = _ctx.IntegerValue("DescribeLiveSnapshotDetectPornConfig.TotalNum");
			describeLiveSnapshotDetectPornConfigResponse.TotalPage = _ctx.IntegerValue("DescribeLiveSnapshotDetectPornConfig.TotalPage");

			List<DescribeLiveSnapshotDetectPornConfigResponse.DescribeLiveSnapshotDetectPornConfig_LiveSnapshotDetectPornConfig> describeLiveSnapshotDetectPornConfigResponse_liveSnapshotDetectPornConfigList = new List<DescribeLiveSnapshotDetectPornConfigResponse.DescribeLiveSnapshotDetectPornConfig_LiveSnapshotDetectPornConfig>();
			for (int i = 0; i < _ctx.Length("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList.Length"); i++) {
				DescribeLiveSnapshotDetectPornConfigResponse.DescribeLiveSnapshotDetectPornConfig_LiveSnapshotDetectPornConfig liveSnapshotDetectPornConfig = new DescribeLiveSnapshotDetectPornConfigResponse.DescribeLiveSnapshotDetectPornConfig_LiveSnapshotDetectPornConfig();
				liveSnapshotDetectPornConfig.DomainName = _ctx.StringValue("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList["+ i +"].DomainName");
				liveSnapshotDetectPornConfig.AppName = _ctx.StringValue("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList["+ i +"].AppName");
				liveSnapshotDetectPornConfig.OssEndpoint = _ctx.StringValue("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList["+ i +"].OssEndpoint");
				liveSnapshotDetectPornConfig.OssBucket = _ctx.StringValue("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList["+ i +"].OssBucket");
				liveSnapshotDetectPornConfig.OssObject = _ctx.StringValue("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList["+ i +"].OssObject");
				liveSnapshotDetectPornConfig.Interval = _ctx.IntegerValue("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList["+ i +"].Interval");

				List<string> liveSnapshotDetectPornConfig_scenes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList["+ i +"].Scenes.Length"); j++) {
					liveSnapshotDetectPornConfig_scenes.Add(_ctx.StringValue("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList["+ i +"].Scenes["+ j +"]"));
				}
				liveSnapshotDetectPornConfig.Scenes = liveSnapshotDetectPornConfig_scenes;

				describeLiveSnapshotDetectPornConfigResponse_liveSnapshotDetectPornConfigList.Add(liveSnapshotDetectPornConfig);
			}
			describeLiveSnapshotDetectPornConfigResponse.LiveSnapshotDetectPornConfigList = describeLiveSnapshotDetectPornConfigResponse_liveSnapshotDetectPornConfigList;
        
			return describeLiveSnapshotDetectPornConfigResponse;
        }
    }
}
