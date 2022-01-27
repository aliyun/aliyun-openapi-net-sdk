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
using Aliyun.Acs.Dyvmsapi.Model.V20170525;

namespace Aliyun.Acs.Dyvmsapi.Transform.V20170525
{
    public class ListHotlineTransferRegisterFileResponseUnmarshaller
    {
        public static ListHotlineTransferRegisterFileResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListHotlineTransferRegisterFileResponse listHotlineTransferRegisterFileResponse = new ListHotlineTransferRegisterFileResponse();

			listHotlineTransferRegisterFileResponse.HttpResponse = _ctx.HttpResponse;
			listHotlineTransferRegisterFileResponse.RequestId = _ctx.StringValue("ListHotlineTransferRegisterFile.RequestId");
			listHotlineTransferRegisterFileResponse.Code = _ctx.StringValue("ListHotlineTransferRegisterFile.Code");
			listHotlineTransferRegisterFileResponse.Message = _ctx.StringValue("ListHotlineTransferRegisterFile.Message");

			ListHotlineTransferRegisterFileResponse.ListHotlineTransferRegisterFile_Data data = new ListHotlineTransferRegisterFileResponse.ListHotlineTransferRegisterFile_Data();
			data.Total = _ctx.LongValue("ListHotlineTransferRegisterFile.Data.Total");
			data.PageNo = _ctx.IntegerValue("ListHotlineTransferRegisterFile.Data.PageNo");
			data.PageSize = _ctx.IntegerValue("ListHotlineTransferRegisterFile.Data.PageSize");

			List<ListHotlineTransferRegisterFileResponse.ListHotlineTransferRegisterFile_Data.ListHotlineTransferRegisterFile_ValuesItem> data_values = new List<ListHotlineTransferRegisterFileResponse.ListHotlineTransferRegisterFile_Data.ListHotlineTransferRegisterFile_ValuesItem>();
			for (int i = 0; i < _ctx.Length("ListHotlineTransferRegisterFile.Data.Values.Length"); i++) {
				ListHotlineTransferRegisterFileResponse.ListHotlineTransferRegisterFile_Data.ListHotlineTransferRegisterFile_ValuesItem valuesItem = new ListHotlineTransferRegisterFileResponse.ListHotlineTransferRegisterFile_Data.ListHotlineTransferRegisterFile_ValuesItem();
				valuesItem.QualificationId = _ctx.StringValue("ListHotlineTransferRegisterFile.Data.Values["+ i +"].QualificationId");
				valuesItem.CorpName = _ctx.StringValue("ListHotlineTransferRegisterFile.Data.Values["+ i +"].CorpName");
				valuesItem.MngOpName = _ctx.StringValue("ListHotlineTransferRegisterFile.Data.Values["+ i +"].MngOpName");
				valuesItem.MngOpMail = _ctx.StringValue("ListHotlineTransferRegisterFile.Data.Values["+ i +"].MngOpMail");
				valuesItem.MngOpMobile = _ctx.StringValue("ListHotlineTransferRegisterFile.Data.Values["+ i +"].MngOpMobile");
				valuesItem.MngOpIdentityCard = _ctx.StringValue("ListHotlineTransferRegisterFile.Data.Values["+ i +"].MngOpIdentityCard");
				valuesItem.Agree = _ctx.StringValue("ListHotlineTransferRegisterFile.Data.Values["+ i +"].Agree");
				valuesItem.ResUniqueCode = _ctx.LongValue("ListHotlineTransferRegisterFile.Data.Values["+ i +"].ResUniqueCode");
				valuesItem.HotlineNumber = _ctx.StringValue("ListHotlineTransferRegisterFile.Data.Values["+ i +"].HotlineNumber");

				data_values.Add(valuesItem);
			}
			data.Values = data_values;
			listHotlineTransferRegisterFileResponse.Data = data;
        
			return listHotlineTransferRegisterFileResponse;
        }
    }
}
