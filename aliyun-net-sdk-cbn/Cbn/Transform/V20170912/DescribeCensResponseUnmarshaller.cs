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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class DescribeCensResponseUnmarshaller
    {
        public static DescribeCensResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCensResponse describeCensResponse = new DescribeCensResponse();

			describeCensResponse.HttpResponse = _ctx.HttpResponse;
			describeCensResponse.RequestId = _ctx.StringValue("DescribeCens.RequestId");
			describeCensResponse.TotalCount = _ctx.IntegerValue("DescribeCens.TotalCount");
			describeCensResponse.PageNumber = _ctx.IntegerValue("DescribeCens.PageNumber");
			describeCensResponse.PageSize = _ctx.IntegerValue("DescribeCens.PageSize");

			List<DescribeCensResponse.DescribeCens_Cen> describeCensResponse_cens = new List<DescribeCensResponse.DescribeCens_Cen>();
			for (int i = 0; i < _ctx.Length("DescribeCens.Cens.Length"); i++) {
				DescribeCensResponse.DescribeCens_Cen cen = new DescribeCensResponse.DescribeCens_Cen();
				cen.CenId = _ctx.StringValue("DescribeCens.Cens["+ i +"].CenId");
				cen.Name = _ctx.StringValue("DescribeCens.Cens["+ i +"].Name");
				cen.Description = _ctx.StringValue("DescribeCens.Cens["+ i +"].Description");
				cen.ProtectionLevel = _ctx.StringValue("DescribeCens.Cens["+ i +"].ProtectionLevel");
				cen.Status = _ctx.StringValue("DescribeCens.Cens["+ i +"].Status");
				cen.CreationTime = _ctx.StringValue("DescribeCens.Cens["+ i +"].CreationTime");
				cen.Ipv6Level = _ctx.StringValue("DescribeCens.Cens["+ i +"].Ipv6Level");

				List<string> cen_cenBandwidthPackageIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCens.Cens["+ i +"].CenBandwidthPackageIds.Length"); j++) {
					cen_cenBandwidthPackageIds.Add(_ctx.StringValue("DescribeCens.Cens["+ i +"].CenBandwidthPackageIds["+ j +"]"));
				}
				cen.CenBandwidthPackageIds = cen_cenBandwidthPackageIds;

				List<DescribeCensResponse.DescribeCens_Cen.DescribeCens_Tag> cen_tags = new List<DescribeCensResponse.DescribeCens_Cen.DescribeCens_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeCens.Cens["+ i +"].Tags.Length"); j++) {
					DescribeCensResponse.DescribeCens_Cen.DescribeCens_Tag tag = new DescribeCensResponse.DescribeCens_Cen.DescribeCens_Tag();
					tag.Key = _ctx.StringValue("DescribeCens.Cens["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeCens.Cens["+ i +"].Tags["+ j +"].Value");

					cen_tags.Add(tag);
				}
				cen.Tags = cen_tags;

				describeCensResponse_cens.Add(cen);
			}
			describeCensResponse.Cens = describeCensResponse_cens;
        
			return describeCensResponse;
        }
    }
}
