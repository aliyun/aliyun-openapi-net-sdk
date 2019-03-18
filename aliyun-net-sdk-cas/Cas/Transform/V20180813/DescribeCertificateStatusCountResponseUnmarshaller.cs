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
    public class DescribeCertificateStatusCountResponseUnmarshaller
    {
        public static DescribeCertificateStatusCountResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCertificateStatusCountResponse describeCertificateStatusCountResponse = new DescribeCertificateStatusCountResponse();

			describeCertificateStatusCountResponse.HttpResponse = context.HttpResponse;
			describeCertificateStatusCountResponse.RequestId = context.StringValue("DescribeCertificateStatusCount.RequestId");
			describeCertificateStatusCountResponse.Payed = context.IntegerValue("DescribeCertificateStatusCount.Payed");
			describeCertificateStatusCountResponse.Checking = context.IntegerValue("DescribeCertificateStatusCount.Checking");
			describeCertificateStatusCountResponse.CheckedFail = context.IntegerValue("DescribeCertificateStatusCount.CheckedFail");
			describeCertificateStatusCountResponse.Issued = context.IntegerValue("DescribeCertificateStatusCount.Issued");
			describeCertificateStatusCountResponse.Revoked = context.IntegerValue("DescribeCertificateStatusCount.Revoked");
			describeCertificateStatusCountResponse.Closed = context.IntegerValue("DescribeCertificateStatusCount.Closed");
			describeCertificateStatusCountResponse.WillExpired = context.IntegerValue("DescribeCertificateStatusCount.WillExpired");
			describeCertificateStatusCountResponse.Expired = context.IntegerValue("DescribeCertificateStatusCount.Expired");
        
			return describeCertificateStatusCountResponse;
        }
    }
}
