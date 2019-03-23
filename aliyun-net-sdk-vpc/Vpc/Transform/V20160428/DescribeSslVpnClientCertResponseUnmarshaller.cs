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
using Aliyun.Acs.Vpc.Model.V20160428;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeSslVpnClientCertResponseUnmarshaller
    {
        public static DescribeSslVpnClientCertResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeSslVpnClientCertResponse describeSslVpnClientCertResponse = new DescribeSslVpnClientCertResponse();

            describeSslVpnClientCertResponse.HttpResponse = context.HttpResponse;
            describeSslVpnClientCertResponse.RequestId = context.StringValue("DescribeSslVpnClientCert.RequestId");
            describeSslVpnClientCertResponse.RegionId = context.StringValue("DescribeSslVpnClientCert.RegionId");
            describeSslVpnClientCertResponse.SslVpnClientCertId = context.StringValue("DescribeSslVpnClientCert.SslVpnClientCertId");
            describeSslVpnClientCertResponse.Name = context.StringValue("DescribeSslVpnClientCert.Name");
            describeSslVpnClientCertResponse.SslVpnServerId = context.StringValue("DescribeSslVpnClientCert.SslVpnServerId");
            describeSslVpnClientCertResponse.CaCert = context.StringValue("DescribeSslVpnClientCert.CaCert");
            describeSslVpnClientCertResponse.ClientCert = context.StringValue("DescribeSslVpnClientCert.ClientCert");
            describeSslVpnClientCertResponse.ClientKey = context.StringValue("DescribeSslVpnClientCert.ClientKey");
            describeSslVpnClientCertResponse.ClientConfig = context.StringValue("DescribeSslVpnClientCert.ClientConfig");
            describeSslVpnClientCertResponse.CreateTime = context.LongValue("DescribeSslVpnClientCert.CreateTime");
            describeSslVpnClientCertResponse.EndTime = context.LongValue("DescribeSslVpnClientCert.EndTime");
            describeSslVpnClientCertResponse.Status = context.StringValue("DescribeSslVpnClientCert.Status");

            return describeSslVpnClientCertResponse;
        }
    }
}