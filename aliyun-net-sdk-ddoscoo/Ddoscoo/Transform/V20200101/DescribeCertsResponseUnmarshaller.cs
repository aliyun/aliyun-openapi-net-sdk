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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeCertsResponseUnmarshaller
    {
        public static DescribeCertsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCertsResponse describeCertsResponse = new DescribeCertsResponse();

			describeCertsResponse.HttpResponse = _ctx.HttpResponse;
			describeCertsResponse.RequestId = _ctx.StringValue("DescribeCerts.RequestId");

			List<DescribeCertsResponse.DescribeCerts_CertItem> describeCertsResponse_certs = new List<DescribeCertsResponse.DescribeCerts_CertItem>();
			for (int i = 0; i < _ctx.Length("DescribeCerts.Certs.Length"); i++) {
				DescribeCertsResponse.DescribeCerts_CertItem certItem = new DescribeCertsResponse.DescribeCerts_CertItem();
				certItem.Id = _ctx.IntegerValue("DescribeCerts.Certs["+ i +"].Id");
				certItem.Name = _ctx.StringValue("DescribeCerts.Certs["+ i +"].Name");
				certItem.Common = _ctx.StringValue("DescribeCerts.Certs["+ i +"].Common");
				certItem.Issuer = _ctx.StringValue("DescribeCerts.Certs["+ i +"].Issuer");
				certItem.StartDate = _ctx.StringValue("DescribeCerts.Certs["+ i +"].StartDate");
				certItem.EndDate = _ctx.StringValue("DescribeCerts.Certs["+ i +"].EndDate");
				certItem.DomainRelated = _ctx.BooleanValue("DescribeCerts.Certs["+ i +"].DomainRelated");

				describeCertsResponse_certs.Add(certItem);
			}
			describeCertsResponse.Certs = describeCertsResponse_certs;
        
			return describeCertsResponse;
        }
    }
}
