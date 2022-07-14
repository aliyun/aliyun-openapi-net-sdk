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
using Aliyun.Acs.antiddos_public.Model.V20170518;

namespace Aliyun.Acs.antiddos_public.Transform.V20170518
{
    public class DescribeDdosCreditResponseUnmarshaller
    {
        public static DescribeDdosCreditResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDdosCreditResponse describeDdosCreditResponse = new DescribeDdosCreditResponse();

			describeDdosCreditResponse.HttpResponse = _ctx.HttpResponse;
			describeDdosCreditResponse.Success = _ctx.BooleanValue("DescribeDdosCredit.Success");
			describeDdosCreditResponse.RequestId = _ctx.StringValue("DescribeDdosCredit.RequestId");

			DescribeDdosCreditResponse.DescribeDdosCredit_DdosCredit ddosCredit = new DescribeDdosCreditResponse.DescribeDdosCredit_DdosCredit();
			ddosCredit.Score = _ctx.IntegerValue("DescribeDdosCredit.DdosCredit.Score");
			ddosCredit.ScoreLevel = _ctx.StringValue("DescribeDdosCredit.DdosCredit.ScoreLevel");
			ddosCredit.BlackholeTime = _ctx.IntegerValue("DescribeDdosCredit.DdosCredit.BlackholeTime");
			describeDdosCreditResponse.DdosCredit = ddosCredit;
        
			return describeDdosCreditResponse;
        }
    }
}
