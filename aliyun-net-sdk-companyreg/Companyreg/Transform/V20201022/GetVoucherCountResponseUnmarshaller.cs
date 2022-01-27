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
using Aliyun.Acs.companyreg.Model.V20201022;

namespace Aliyun.Acs.companyreg.Transform.V20201022
{
    public class GetVoucherCountResponseUnmarshaller
    {
        public static GetVoucherCountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVoucherCountResponse getVoucherCountResponse = new GetVoucherCountResponse();

			getVoucherCountResponse.HttpResponse = _ctx.HttpResponse;
			getVoucherCountResponse.RequestId = _ctx.StringValue("GetVoucherCount.RequestId");

			List<GetVoucherCountResponse.GetVoucherCount_DataItem> getVoucherCountResponse_data = new List<GetVoucherCountResponse.GetVoucherCount_DataItem>();
			for (int i = 0; i < _ctx.Length("GetVoucherCount.Data.Length"); i++) {
				GetVoucherCountResponse.GetVoucherCount_DataItem dataItem = new GetVoucherCountResponse.GetVoucherCount_DataItem();
				dataItem.Period = _ctx.StringValue("GetVoucherCount.Data["+ i +"].Period");
				dataItem.Count = _ctx.IntegerValue("GetVoucherCount.Data["+ i +"].Count");

				getVoucherCountResponse_data.Add(dataItem);
			}
			getVoucherCountResponse.Data = getVoucherCountResponse_data;
        
			return getVoucherCountResponse;
        }
    }
}
