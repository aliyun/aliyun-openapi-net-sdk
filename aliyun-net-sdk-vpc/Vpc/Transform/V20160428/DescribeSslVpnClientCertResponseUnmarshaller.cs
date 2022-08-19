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
    public class DescribeSslVpnClientCertResponseUnmarshaller
    {
        public static DescribeSslVpnClientCertResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSslVpnClientCertResponse describeSslVpnClientCertResponse = new DescribeSslVpnClientCertResponse();

			describeSslVpnClientCertResponse.HttpResponse = _ctx.HttpResponse;
			describeSslVpnClientCertResponse.Status = _ctx.StringValue("DescribeSslVpnClientCert.Status");
			describeSslVpnClientCertResponse.CreateTime = _ctx.LongValue("DescribeSslVpnClientCert.CreateTime");
			describeSslVpnClientCertResponse.ClientKey = _ctx.StringValue("DescribeSslVpnClientCert.ClientKey");
			describeSslVpnClientCertResponse.RegionId = _ctx.StringValue("DescribeSslVpnClientCert.RegionId");
			describeSslVpnClientCertResponse.ClientConfig = _ctx.StringValue("DescribeSslVpnClientCert.ClientConfig");
			describeSslVpnClientCertResponse.EndTime = _ctx.LongValue("DescribeSslVpnClientCert.EndTime");
			describeSslVpnClientCertResponse.RequestId = _ctx.StringValue("DescribeSslVpnClientCert.RequestId");
			describeSslVpnClientCertResponse.ClientCert = _ctx.StringValue("DescribeSslVpnClientCert.ClientCert");
			describeSslVpnClientCertResponse.CaCert = _ctx.StringValue("DescribeSslVpnClientCert.CaCert");
			describeSslVpnClientCertResponse.SslVpnClientCertId = _ctx.StringValue("DescribeSslVpnClientCert.SslVpnClientCertId");
			describeSslVpnClientCertResponse.SslVpnServerId = _ctx.StringValue("DescribeSslVpnClientCert.SslVpnServerId");
			describeSslVpnClientCertResponse.Name = _ctx.StringValue("DescribeSslVpnClientCert.Name");
        
			return describeSslVpnClientCertResponse;
        }
    }
}
