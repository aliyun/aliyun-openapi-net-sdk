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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnOfflineLogDeliveryResponseUnmarshaller
    {
        public static DescribeDcdnOfflineLogDeliveryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnOfflineLogDeliveryResponse describeDcdnOfflineLogDeliveryResponse = new DescribeDcdnOfflineLogDeliveryResponse();

			describeDcdnOfflineLogDeliveryResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnOfflineLogDeliveryResponse.RequestId = _ctx.StringValue("DescribeDcdnOfflineLogDelivery.RequestId");

			List<string> describeDcdnOfflineLogDeliveryResponse_fields = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnOfflineLogDelivery.Fields.Length"); i++) {
				describeDcdnOfflineLogDeliveryResponse_fields.Add(_ctx.StringValue("DescribeDcdnOfflineLogDelivery.Fields["+ i +"]"));
			}
			describeDcdnOfflineLogDeliveryResponse.Fields = describeDcdnOfflineLogDeliveryResponse_fields;

			List<DescribeDcdnOfflineLogDeliveryResponse.DescribeDcdnOfflineLogDelivery_Domain> describeDcdnOfflineLogDeliveryResponse_domains = new List<DescribeDcdnOfflineLogDeliveryResponse.DescribeDcdnOfflineLogDelivery_Domain>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnOfflineLogDelivery.Domains.Length"); i++) {
				DescribeDcdnOfflineLogDeliveryResponse.DescribeDcdnOfflineLogDelivery_Domain domain = new DescribeDcdnOfflineLogDeliveryResponse.DescribeDcdnOfflineLogDelivery_Domain();
				domain.DomainName = _ctx.StringValue("DescribeDcdnOfflineLogDelivery.Domains["+ i +"].DomainName");

				describeDcdnOfflineLogDeliveryResponse_domains.Add(domain);
			}
			describeDcdnOfflineLogDeliveryResponse.Domains = describeDcdnOfflineLogDeliveryResponse_domains;

			List<DescribeDcdnOfflineLogDeliveryResponse.DescribeDcdnOfflineLogDelivery_Region> describeDcdnOfflineLogDeliveryResponse_regions = new List<DescribeDcdnOfflineLogDeliveryResponse.DescribeDcdnOfflineLogDelivery_Region>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnOfflineLogDelivery.Regions.Length"); i++) {
				DescribeDcdnOfflineLogDeliveryResponse.DescribeDcdnOfflineLogDelivery_Region region = new DescribeDcdnOfflineLogDeliveryResponse.DescribeDcdnOfflineLogDelivery_Region();
				region.OssId = _ctx.IntegerValue("DescribeDcdnOfflineLogDelivery.Regions["+ i +"].OssId");
				region.OssBucketName = _ctx.StringValue("DescribeDcdnOfflineLogDelivery.Regions["+ i +"].OssBucketName");
				region.OssPathPrefix = _ctx.StringValue("DescribeDcdnOfflineLogDelivery.Regions["+ i +"].OssPathPrefix");
				region.DlaVcName = _ctx.StringValue("DescribeDcdnOfflineLogDelivery.Regions["+ i +"].DlaVcName");
				region.RegionId = _ctx.StringValue("DescribeDcdnOfflineLogDelivery.Regions["+ i +"].RegionId");
				region.RegionName = _ctx.StringValue("DescribeDcdnOfflineLogDelivery.Regions["+ i +"].RegionName");
				region.IsOverseas = _ctx.StringValue("DescribeDcdnOfflineLogDelivery.Regions["+ i +"].IsOverseas");
				region.OssEndpoint = _ctx.StringValue("DescribeDcdnOfflineLogDelivery.Regions["+ i +"].OssEndpoint");
				region.AreaId = _ctx.StringValue("DescribeDcdnOfflineLogDelivery.Regions["+ i +"].AreaId");
				region.AreaName = _ctx.StringValue("DescribeDcdnOfflineLogDelivery.Regions["+ i +"].AreaName");
				region.DlaDbName = _ctx.StringValue("DescribeDcdnOfflineLogDelivery.Regions["+ i +"].DlaDbName");
				region.DlaTableName = _ctx.StringValue("DescribeDcdnOfflineLogDelivery.Regions["+ i +"].DlaTableName");

				describeDcdnOfflineLogDeliveryResponse_regions.Add(region);
			}
			describeDcdnOfflineLogDeliveryResponse.Regions = describeDcdnOfflineLogDeliveryResponse_regions;
        
			return describeDcdnOfflineLogDeliveryResponse;
        }
    }
}
