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
    public class DescribeDomainWithIntegrityResponseUnmarshaller
    {
        public static DescribeDomainWithIntegrityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainWithIntegrityResponse describeDomainWithIntegrityResponse = new DescribeDomainWithIntegrityResponse();

			describeDomainWithIntegrityResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainWithIntegrityResponse.RequestId = _ctx.StringValue("DescribeDomainWithIntegrity.RequestId");

			List<DescribeDomainWithIntegrityResponse.DescribeDomainWithIntegrity_ContentItem> describeDomainWithIntegrityResponse_content = new List<DescribeDomainWithIntegrityResponse.DescribeDomainWithIntegrity_ContentItem>();
			for (int i = 0; i < _ctx.Length("DescribeDomainWithIntegrity.Content.Length"); i++) {
				DescribeDomainWithIntegrityResponse.DescribeDomainWithIntegrity_ContentItem contentItem = new DescribeDomainWithIntegrityResponse.DescribeDomainWithIntegrity_ContentItem();
				contentItem.Name = _ctx.StringValue("DescribeDomainWithIntegrity.Content["+ i +"].Name");

				List<string> contentItem_points = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDomainWithIntegrity.Content["+ i +"].Points.Length"); j++) {
					contentItem_points.Add(_ctx.StringValue("DescribeDomainWithIntegrity.Content["+ i +"].Points["+ j +"]"));
				}
				contentItem.Points = contentItem_points;

				List<string> contentItem_columns = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDomainWithIntegrity.Content["+ i +"].Columns.Length"); j++) {
					contentItem_columns.Add(_ctx.StringValue("DescribeDomainWithIntegrity.Content["+ i +"].Columns["+ j +"]"));
				}
				contentItem.Columns = contentItem_columns;

				describeDomainWithIntegrityResponse_content.Add(contentItem);
			}
			describeDomainWithIntegrityResponse.Content = describeDomainWithIntegrityResponse_content;
        
			return describeDomainWithIntegrityResponse;
        }
    }
}
