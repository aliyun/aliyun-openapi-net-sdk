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
using Aliyun.Acs.geoip.Model.V20200101;

namespace Aliyun.Acs.geoip.Transform.V20200101
{
    public class DescribeGeoipInstanceDataInfosResponseUnmarshaller
    {
        public static DescribeGeoipInstanceDataInfosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGeoipInstanceDataInfosResponse describeGeoipInstanceDataInfosResponse = new DescribeGeoipInstanceDataInfosResponse();

			describeGeoipInstanceDataInfosResponse.HttpResponse = _ctx.HttpResponse;
			describeGeoipInstanceDataInfosResponse.RequestId = _ctx.StringValue("DescribeGeoipInstanceDataInfos.RequestId");

			List<DescribeGeoipInstanceDataInfosResponse.DescribeGeoipInstanceDataInfos_DataInfo> describeGeoipInstanceDataInfosResponse_dataInfos = new List<DescribeGeoipInstanceDataInfosResponse.DescribeGeoipInstanceDataInfos_DataInfo>();
			for (int i = 0; i < _ctx.Length("DescribeGeoipInstanceDataInfos.DataInfos.Length"); i++) {
				DescribeGeoipInstanceDataInfosResponse.DescribeGeoipInstanceDataInfos_DataInfo dataInfo = new DescribeGeoipInstanceDataInfosResponse.DescribeGeoipInstanceDataInfos_DataInfo();
				dataInfo.Type = _ctx.StringValue("DescribeGeoipInstanceDataInfos.DataInfos["+ i +"].Type");
				dataInfo.Version = _ctx.StringValue("DescribeGeoipInstanceDataInfos.DataInfos["+ i +"].Version");
				dataInfo.UpdateTime = _ctx.StringValue("DescribeGeoipInstanceDataInfos.DataInfos["+ i +"].UpdateTime");
				dataInfo.UpdateTimestamp = _ctx.LongValue("DescribeGeoipInstanceDataInfos.DataInfos["+ i +"].UpdateTimestamp");
				dataInfo.DownloadCount = _ctx.LongValue("DescribeGeoipInstanceDataInfos.DataInfos["+ i +"].DownloadCount");

				describeGeoipInstanceDataInfosResponse_dataInfos.Add(dataInfo);
			}
			describeGeoipInstanceDataInfosResponse.DataInfos = describeGeoipInstanceDataInfosResponse_dataInfos;
        
			return describeGeoipInstanceDataInfosResponse;
        }
    }
}
