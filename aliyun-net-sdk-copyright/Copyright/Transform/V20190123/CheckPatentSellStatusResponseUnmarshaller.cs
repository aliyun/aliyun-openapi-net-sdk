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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class CheckPatentSellStatusResponseUnmarshaller
    {
        public static CheckPatentSellStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckPatentSellStatusResponse checkPatentSellStatusResponse = new CheckPatentSellStatusResponse();

			checkPatentSellStatusResponse.HttpResponse = _ctx.HttpResponse;
			checkPatentSellStatusResponse.RequestId = _ctx.StringValue("CheckPatentSellStatus.RequestId");
			checkPatentSellStatusResponse.Success = _ctx.BooleanValue("CheckPatentSellStatus.Success");

			List<CheckPatentSellStatusResponse.CheckPatentSellStatus_DataItem> checkPatentSellStatusResponse_data = new List<CheckPatentSellStatusResponse.CheckPatentSellStatus_DataItem>();
			for (int i = 0; i < _ctx.Length("CheckPatentSellStatus.Data.Length"); i++) {
				CheckPatentSellStatusResponse.CheckPatentSellStatus_DataItem dataItem = new CheckPatentSellStatusResponse.CheckPatentSellStatus_DataItem();
				dataItem.Age = _ctx.StringValue("CheckPatentSellStatus.Data["+ i +"].Age");
				dataItem.ApplyNumber = _ctx.StringValue("CheckPatentSellStatus.Data["+ i +"].ApplyNumber");
				dataItem.Discount = _ctx.StringValue("CheckPatentSellStatus.Data["+ i +"].Discount");
				dataItem.EndDate = _ctx.StringValue("CheckPatentSellStatus.Data["+ i +"].EndDate");
				dataItem.ErrorMessage = _ctx.StringValue("CheckPatentSellStatus.Data["+ i +"].ErrorMessage");
				dataItem.Fee = _ctx.FloatValue("CheckPatentSellStatus.Data["+ i +"].Fee");
				dataItem.Type = _ctx.StringValue("CheckPatentSellStatus.Data["+ i +"].Type");

				checkPatentSellStatusResponse_data.Add(dataItem);
			}
			checkPatentSellStatusResponse.Data = checkPatentSellStatusResponse_data;
        
			return checkPatentSellStatusResponse;
        }
    }
}
