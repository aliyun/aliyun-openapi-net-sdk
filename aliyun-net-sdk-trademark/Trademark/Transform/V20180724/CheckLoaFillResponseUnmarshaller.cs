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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class CheckLoaFillResponseUnmarshaller
    {
        public static CheckLoaFillResponse Unmarshall(UnmarshallerContext context)
        {
			CheckLoaFillResponse checkLoaFillResponse = new CheckLoaFillResponse();

			checkLoaFillResponse.HttpResponse = context.HttpResponse;
			checkLoaFillResponse.RequestId = context.StringValue("CheckLoaFill.RequestId");

			CheckLoaFillResponse.CheckLoaFill_Data data = new CheckLoaFillResponse.CheckLoaFill_Data();
			data.StampFill = context.BooleanValue("CheckLoaFill.Data.StampFill");
			data.AddressFill = context.BooleanValue("CheckLoaFill.Data.AddressFill");
			data.TradeMarkNameFill = context.BooleanValue("CheckLoaFill.Data.TradeMarkNameFill");
			data.CountryFill = context.BooleanValue("CheckLoaFill.Data.CountryFill");
			data.NationalityFill = context.BooleanValue("CheckLoaFill.Data.NationalityFill");
			data.MaterialNameFill = context.BooleanValue("CheckLoaFill.Data.MaterialNameFill");
			data.TemplateUrl = context.StringValue("CheckLoaFill.Data.TemplateUrl");

			List<string> data_errorMsgs = new List<string>();
			for (int i = 0; i < context.Length("CheckLoaFill.Data.ErrorMsgs.Length"); i++) {
				data_errorMsgs.Add(context.StringValue("CheckLoaFill.Data.ErrorMsgs["+ i +"]"));
			}
			data.ErrorMsgs = data_errorMsgs;
			checkLoaFillResponse.Data = data;
        
			return checkLoaFillResponse;
        }
    }
}
