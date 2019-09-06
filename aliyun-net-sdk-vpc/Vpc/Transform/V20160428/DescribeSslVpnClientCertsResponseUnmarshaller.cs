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
        public static DescribeSslVpnClientCertsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSslVpnClientCertsResponse describeSslVpnClientCertsResponse = new DescribeSslVpnClientCertsResponse();

			describeSslVpnClientCertsResponse.HttpResponse = context.HttpResponse;
			describeSslVpnClientCertsResponse.RequestId = context.StringValue("DescribeSslVpnClientCerts.RequestId");
			describeSslVpnClientCertsResponse.TotalCount = context.IntegerValue("DescribeSslVpnClientCerts.TotalCount");
			describeSslVpnClientCertsResponse.PageNumber = context.IntegerValue("DescribeSslVpnClientCerts.PageNumber");
			describeSslVpnClientCertsResponse.PageSize = context.IntegerValue("DescribeSslVpnClientCerts.PageSize");

			List<DescribeSslVpnClientCertsResponse.DescribeSslVpnClientCerts_SslVpnClientCertKey> describeSslVpnClientCertsResponse_sslVpnClientCertKeys = new List<DescribeSslVpnClientCertsResponse.DescribeSslVpnClientCerts_SslVpnClientCertKey>();
			for (int i = 0; i < context.Length("DescribeSslVpnClientCerts.SslVpnClientCertKeys.Length"); i++) {
				DescribeSslVpnClientCertsResponse.DescribeSslVpnClientCerts_SslVpnClientCertKey sslVpnClientCertKey = new DescribeSslVpnClientCertsResponse.DescribeSslVpnClientCerts_SslVpnClientCertKey();
				sslVpnClientCertKey.RegionId = context.StringValue("DescribeSslVpnClientCerts.SslVpnClientCertKeys["+ i +"].RegionId");
				sslVpnClientCertKey.SslVpnClientCertId = context.StringValue("DescribeSslVpnClientCerts.SslVpnClientCertKeys["+ i +"].SslVpnClientCertId");
				sslVpnClientCertKey.Name = context.StringValue("DescribeSslVpnClientCerts.SslVpnClientCertKeys["+ i +"].Name");
				sslVpnClientCertKey.SslVpnServerId = context.StringValue("DescribeSslVpnClientCerts.SslVpnClientCertKeys["+ i +"].SslVpnServerId");
				sslVpnClientCertKey.CreateTime = context.LongValue("DescribeSslVpnClientCerts.SslVpnClientCertKeys["+ i +"].CreateTime");
				sslVpnClientCertKey.EndTime = context.LongValue("DescribeSslVpnClientCerts.SslVpnClientCertKeys["+ i +"].EndTime");
				sslVpnClientCertKey.Status = context.StringValue("DescribeSslVpnClientCerts.SslVpnClientCertKeys["+ i +"].Status");

				describeSslVpnClientCertsResponse_sslVpnClientCertKeys.Add(sslVpnClientCertKey);
			}
			describeSslVpnClientCertsResponse.SslVpnClientCertKeys = describeSslVpnClientCertsResponse_sslVpnClientCertKeys;
        
			return describeSslVpnClientCertsResponse;
        }
    }
}
