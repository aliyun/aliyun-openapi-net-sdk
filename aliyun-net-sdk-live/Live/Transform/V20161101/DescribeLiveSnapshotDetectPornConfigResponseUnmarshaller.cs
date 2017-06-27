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
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveSnapshotDetectPornConfigResponseUnmarshaller
    {
        public static DescribeLiveSnapshotDetectPornConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveSnapshotDetectPornConfigResponse describeLiveSnapshotDetectPornConfigResponse = new DescribeLiveSnapshotDetectPornConfigResponse();

			describeLiveSnapshotDetectPornConfigResponse.HttpResponse = context.HttpResponse;
			describeLiveSnapshotDetectPornConfigResponse.RequestId = context.StringValue("DescribeLiveSnapshotDetectPornConfig.RequestId");
			describeLiveSnapshotDetectPornConfigResponse.PageNum = context.IntegerValue("DescribeLiveSnapshotDetectPornConfig.PageNum");
			describeLiveSnapshotDetectPornConfigResponse.PageSize = context.IntegerValue("DescribeLiveSnapshotDetectPornConfig.PageSize");
			describeLiveSnapshotDetectPornConfigResponse.Order = context.StringValue("DescribeLiveSnapshotDetectPornConfig.Order");
			describeLiveSnapshotDetectPornConfigResponse.TotalNum = context.IntegerValue("DescribeLiveSnapshotDetectPornConfig.TotalNum");
			describeLiveSnapshotDetectPornConfigResponse.TotalPage = context.IntegerValue("DescribeLiveSnapshotDetectPornConfig.TotalPage");

			List<DescribeLiveSnapshotDetectPornConfigResponse.LiveSnapshotDetectPornConfig> liveSnapshotDetectPornConfigList = new List<DescribeLiveSnapshotDetectPornConfigResponse.LiveSnapshotDetectPornConfig>();
			for (int i = 0; i < context.Length("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList.Length"); i++) {
				DescribeLiveSnapshotDetectPornConfigResponse.LiveSnapshotDetectPornConfig liveSnapshotDetectPornConfig = new DescribeLiveSnapshotDetectPornConfigResponse.LiveSnapshotDetectPornConfig();
				liveSnapshotDetectPornConfig.DomainName = context.StringValue("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList["+ i +"].DomainName");
				liveSnapshotDetectPornConfig.AppName = context.StringValue("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList["+ i +"].AppName");
				liveSnapshotDetectPornConfig.OssEndpoint = context.StringValue("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList["+ i +"].OssEndpoint");
				liveSnapshotDetectPornConfig.OssBucket = context.StringValue("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList["+ i +"].OssBucket");
				liveSnapshotDetectPornConfig.OssObject = context.StringValue("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList["+ i +"].OssObject");
				liveSnapshotDetectPornConfig.Interval = context.IntegerValue("DescribeLiveSnapshotDetectPornConfig.LiveSnapshotDetectPornConfigList["+ i +"].Interval");

				liveSnapshotDetectPornConfigList.Add(liveSnapshotDetectPornConfig);
			}
			describeLiveSnapshotDetectPornConfigResponse.LiveSnapshotDetectPornConfigList = liveSnapshotDetectPornConfigList;
        
			return describeLiveSnapshotDetectPornConfigResponse;
        }
    }
}