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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class AddDeviceToSharePromotionResponseUnmarshaller
    {
        public static AddDeviceToSharePromotionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddDeviceToSharePromotionResponse addDeviceToSharePromotionResponse = new AddDeviceToSharePromotionResponse();

			addDeviceToSharePromotionResponse.HttpResponse = _ctx.HttpResponse;
			addDeviceToSharePromotionResponse.RequestId = _ctx.StringValue("AddDeviceToSharePromotion.RequestId");
			addDeviceToSharePromotionResponse.Success = _ctx.BooleanValue("AddDeviceToSharePromotion.Success");
			addDeviceToSharePromotionResponse.Code = _ctx.StringValue("AddDeviceToSharePromotion.Code");
			addDeviceToSharePromotionResponse.ErrorMessage = _ctx.StringValue("AddDeviceToSharePromotion.ErrorMessage");

			AddDeviceToSharePromotionResponse.AddDeviceToSharePromotion_Data data = new AddDeviceToSharePromotionResponse.AddDeviceToSharePromotion_Data();

			List<AddDeviceToSharePromotionResponse.AddDeviceToSharePromotion_Data.AddDeviceToSharePromotion_Item> data_failDeviceSimpleInfoList = new List<AddDeviceToSharePromotionResponse.AddDeviceToSharePromotion_Data.AddDeviceToSharePromotion_Item>();
			for (int i = 0; i < _ctx.Length("AddDeviceToSharePromotion.Data.FailDeviceSimpleInfoList.Length"); i++) {
				AddDeviceToSharePromotionResponse.AddDeviceToSharePromotion_Data.AddDeviceToSharePromotion_Item item = new AddDeviceToSharePromotionResponse.AddDeviceToSharePromotion_Data.AddDeviceToSharePromotion_Item();
				item.ProductKey = _ctx.StringValue("AddDeviceToSharePromotion.Data.FailDeviceSimpleInfoList["+ i +"].ProductKey");
				item.DeviceName = _ctx.StringValue("AddDeviceToSharePromotion.Data.FailDeviceSimpleInfoList["+ i +"].DeviceName");
				item.FailCode = _ctx.IntegerValue("AddDeviceToSharePromotion.Data.FailDeviceSimpleInfoList["+ i +"].FailCode");
				item.FailReason = _ctx.StringValue("AddDeviceToSharePromotion.Data.FailDeviceSimpleInfoList["+ i +"].FailReason");

				data_failDeviceSimpleInfoList.Add(item);
			}
			data.FailDeviceSimpleInfoList = data_failDeviceSimpleInfoList;
			addDeviceToSharePromotionResponse.Data = data;
        
			return addDeviceToSharePromotionResponse;
        }
    }
}
