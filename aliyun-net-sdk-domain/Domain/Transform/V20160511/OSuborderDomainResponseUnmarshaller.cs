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
using Aliyun.Acs.Domain.Model.V20160511;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20160511
{
    public class OSuborderDomainResponseUnmarshaller
    {
        public static OSuborderDomainResponse Unmarshall(UnmarshallerContext context)
        {
			OSuborderDomainResponse oSuborderDomainResponse = new OSuborderDomainResponse();

			oSuborderDomainResponse.HttpResponse = context.HttpResponse;
			oSuborderDomainResponse.RequestId = context.StringValue("OSuborderDomain.RequestId");
			oSuborderDomainResponse.TotalItemNum = context.IntegerValue("OSuborderDomain.TotalItemNum");
			oSuborderDomainResponse.CurrentPageNum = context.IntegerValue("OSuborderDomain.CurrentPageNum");
			oSuborderDomainResponse.PageSize = context.IntegerValue("OSuborderDomain.PageSize");

			List<OSuborderDomainResponse.OSuborderDomain__Object> oSuborderDomainResponse_data = new List<OSuborderDomainResponse.OSuborderDomain__Object>();
			for (int i = 0; i < context.Length("OSuborderDomain.Data.Length"); i++) {
				OSuborderDomainResponse.OSuborderDomain__Object _object = new OSuborderDomainResponse.OSuborderDomain__Object();
				_object.CommodityKey = context.StringValue("OSuborderDomain.Data["+ i +"].CommodityKey");
				_object.CommodityCode = context.StringValue("OSuborderDomain.Data["+ i +"].CommodityCode");
				_object.Amount = context.LongValue("OSuborderDomain.Data["+ i +"].Amount");
				_object.SettleTime = context.StringValue("OSuborderDomain.Data["+ i +"].SettleTime");

				oSuborderDomainResponse_data.Add(_object);
			}
			oSuborderDomainResponse.Data = oSuborderDomainResponse_data;
        
			return oSuborderDomainResponse;
        }
    }
}