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
using Aliyun.Acs.Push.Model.V20160801;

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class CheckCertificateResponseUnmarshaller
    {
        public static CheckCertificateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckCertificateResponse checkCertificateResponse = new CheckCertificateResponse();

			checkCertificateResponse.HttpResponse = _ctx.HttpResponse;
			checkCertificateResponse.RequestId = _ctx.StringValue("CheckCertificate.RequestId");
			checkCertificateResponse.Android = _ctx.BooleanValue("CheckCertificate.Android");
			checkCertificateResponse.IOS = _ctx.BooleanValue("CheckCertificate.IOS");

			CheckCertificateResponse.CheckCertificate_ProductionCertInfo productionCertInfo = new CheckCertificateResponse.CheckCertificate_ProductionCertInfo();
			productionCertInfo.ExipreTime = _ctx.LongValue("CheckCertificate.ProductionCertInfo.ExipreTime");
			productionCertInfo.Status = _ctx.StringValue("CheckCertificate.ProductionCertInfo.Status");
			checkCertificateResponse.ProductionCertInfo = productionCertInfo;

			CheckCertificateResponse.CheckCertificate_DevelopmentCertInfo developmentCertInfo = new CheckCertificateResponse.CheckCertificate_DevelopmentCertInfo();
			developmentCertInfo.ExipreTime = _ctx.LongValue("CheckCertificate.DevelopmentCertInfo.ExipreTime");
			developmentCertInfo.Status = _ctx.StringValue("CheckCertificate.DevelopmentCertInfo.Status");
			checkCertificateResponse.DevelopmentCertInfo = developmentCertInfo;
        
			return checkCertificateResponse;
        }
    }
}
