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
using Aliyun.Acs.cas.Model.V20180813;

namespace Aliyun.Acs.cas.Transform.V20180813
{
    public class DescribeCertificateBrandListResponseUnmarshaller
    {
        public static DescribeCertificateBrandListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCertificateBrandListResponse describeCertificateBrandListResponse = new DescribeCertificateBrandListResponse();

			describeCertificateBrandListResponse.HttpResponse = context.HttpResponse;
			describeCertificateBrandListResponse.RequestId = context.StringValue("DescribeCertificateBrandList.RequestId");

			List<DescribeCertificateBrandListResponse.DescribeCertificateBrandList_Brand> describeCertificateBrandListResponse_brandList = new List<DescribeCertificateBrandListResponse.DescribeCertificateBrandList_Brand>();
			for (int i = 0; i < context.Length("DescribeCertificateBrandList.BrandList.Length"); i++) {
				DescribeCertificateBrandListResponse.DescribeCertificateBrandList_Brand brand = new DescribeCertificateBrandListResponse.DescribeCertificateBrandList_Brand();
				brand.Id = context.LongValue("DescribeCertificateBrandList.BrandList["+ i +"].Id");
				brand.Name = context.StringValue("DescribeCertificateBrandList.BrandList["+ i +"].Name");

				describeCertificateBrandListResponse_brandList.Add(brand);
			}
			describeCertificateBrandListResponse.BrandList = describeCertificateBrandListResponse_brandList;
        
			return describeCertificateBrandListResponse;
        }
    }
}
