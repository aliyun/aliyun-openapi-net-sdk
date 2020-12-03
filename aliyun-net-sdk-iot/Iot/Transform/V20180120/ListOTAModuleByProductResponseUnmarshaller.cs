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
    public class ListOTAModuleByProductResponseUnmarshaller
    {
        public static ListOTAModuleByProductResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOTAModuleByProductResponse listOTAModuleByProductResponse = new ListOTAModuleByProductResponse();

			listOTAModuleByProductResponse.HttpResponse = _ctx.HttpResponse;
			listOTAModuleByProductResponse.RequestId = _ctx.StringValue("ListOTAModuleByProduct.RequestId");
			listOTAModuleByProductResponse.Success = _ctx.BooleanValue("ListOTAModuleByProduct.Success");
			listOTAModuleByProductResponse.Code = _ctx.StringValue("ListOTAModuleByProduct.Code");
			listOTAModuleByProductResponse.ErrorMessage = _ctx.StringValue("ListOTAModuleByProduct.ErrorMessage");

			List<ListOTAModuleByProductResponse.ListOTAModuleByProduct_OtaModuleDTO> listOTAModuleByProductResponse_data = new List<ListOTAModuleByProductResponse.ListOTAModuleByProduct_OtaModuleDTO>();
			for (int i = 0; i < _ctx.Length("ListOTAModuleByProduct.Data.Length"); i++) {
				ListOTAModuleByProductResponse.ListOTAModuleByProduct_OtaModuleDTO otaModuleDTO = new ListOTAModuleByProductResponse.ListOTAModuleByProduct_OtaModuleDTO();
				otaModuleDTO.ProductKey = _ctx.StringValue("ListOTAModuleByProduct.Data["+ i +"].ProductKey");
				otaModuleDTO.ModuleName = _ctx.StringValue("ListOTAModuleByProduct.Data["+ i +"].ModuleName");
				otaModuleDTO.AliasName = _ctx.StringValue("ListOTAModuleByProduct.Data["+ i +"].AliasName");
				otaModuleDTO.Desc = _ctx.StringValue("ListOTAModuleByProduct.Data["+ i +"].Desc");
				otaModuleDTO.GmtCreate = _ctx.StringValue("ListOTAModuleByProduct.Data["+ i +"].GmtCreate");
				otaModuleDTO.GmtModified = _ctx.StringValue("ListOTAModuleByProduct.Data["+ i +"].GmtModified");

				listOTAModuleByProductResponse_data.Add(otaModuleDTO);
			}
			listOTAModuleByProductResponse.Data = listOTAModuleByProductResponse_data;
        
			return listOTAModuleByProductResponse;
        }
    }
}
