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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeSslVpnClientCertsResponseUnmarshaller
    {
        public static DescribeSslVpnClientCertsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSslVpnClientCertsResponse describeSslVpnClientCertsResponse = new DescribeSslVpnClientCertsResponse();

			describeSslVpnClientCertsResponse.HttpResponse = _ctx.HttpResponse;
			describeSslVpnClientCertsResponse.RequestId = _ctx.StringValue("DescribeSslVpnClientCerts.RequestId");
			describeSslVpnClientCertsResponse.TotalCount = _ctx.IntegerValue("DescribeSslVpnClientCerts.TotalCount");
			describeSslVpnClientCertsResponse.PageNumber = _ctx.IntegerValue("DescribeSslVpnClientCerts.PageNumber");
			describeSslVpnClientCertsResponse.PageSize = _ctx.IntegerValue("DescribeSslVpnClientCerts.PageSize");

			List<DescribeSslVpnClientCertsResponse.DescribeSslVpnClientCerts_SslVpnClientCertKey> describeSslVpnClientCertsResponse_sslVpnClientCertKeys = new List<DescribeSslVpnClientCertsResponse.DescribeSslVpnClientCerts_SslVpnClientCertKey>();
			for (int i = 0; i < _ctx.Length("DescribeSslVpnClientCerts.SslVpnClientCertKeys.Length"); i++) {
				DescribeSslVpnClientCertsResponse.DescribeSslVpnClientCerts_SslVpnClientCertKey sslVpnClientCertKey = new DescribeSslVpnClientCertsResponse.DescribeSslVpnClientCerts_SslVpnClientCertKey();
				sslVpnClientCertKey.RegionId = _ctx.StringValue("DescribeSslVpnClientCerts.SslVpnClientCertKeys["+ i +"].RegionId");
				sslVpnClientCertKey.SslVpnClientCertId = _ctx.StringValue("DescribeSslVpnClientCerts.SslVpnClientCertKeys["+ i +"].SslVpnClientCertId");
				sslVpnClientCertKey.Name = _ctx.StringValue("DescribeSslVpnClientCerts.SslVpnClientCertKeys["+ i +"].Name");
				sslVpnClientCertKey.SslVpnServerId = _ctx.StringValue("DescribeSslVpnClientCerts.SslVpnClientCertKeys["+ i +"].SslVpnServerId");
				sslVpnClientCertKey.CreateTime = _ctx.LongValue("DescribeSslVpnClientCerts.SslVpnClientCertKeys["+ i +"].CreateTime");
				sslVpnClientCertKey.EndTime = _ctx.LongValue("DescribeSslVpnClientCerts.SslVpnClientCertKeys["+ i +"].EndTime");
				sslVpnClientCertKey.Status = _ctx.StringValue("DescribeSslVpnClientCerts.SslVpnClientCertKeys["+ i +"].Status");

				describeSslVpnClientCertsResponse_sslVpnClientCertKeys.Add(sslVpnClientCertKey);
			}
			describeSslVpnClientCertsResponse.SslVpnClientCertKeys = describeSslVpnClientCertsResponse_sslVpnClientCertKeys;
        
			return describeSslVpnClientCertsResponse;
        }
    }
}
