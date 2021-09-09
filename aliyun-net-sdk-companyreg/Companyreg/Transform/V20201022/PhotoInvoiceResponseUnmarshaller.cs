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
    public class PhotoInvoiceResponseUnmarshaller
    {
        public static PhotoInvoiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PhotoInvoiceResponse photoInvoiceResponse = new PhotoInvoiceResponse();

			photoInvoiceResponse.HttpResponse = _ctx.HttpResponse;
			photoInvoiceResponse.RequestId = _ctx.StringValue("PhotoInvoice.RequestId");

			List<PhotoInvoiceResponse.PhotoInvoice_ItemItem> photoInvoiceResponse_item = new List<PhotoInvoiceResponse.PhotoInvoice_ItemItem>();
			for (int i = 0; i < _ctx.Length("PhotoInvoice.Item.Length"); i++) {
				PhotoInvoiceResponse.PhotoInvoice_ItemItem itemItem = new PhotoInvoiceResponse.PhotoInvoice_ItemItem();
				itemItem.NoteRecognizedStatus = _ctx.StringValue("PhotoInvoice.Item["+ i +"].NoteRecognizedStatus");
				itemItem.TargetBoName = _ctx.StringValue("PhotoInvoice.Item["+ i +"].TargetBoName");
				itemItem.TargetVoucherId = _ctx.LongValue("PhotoInvoice.Item["+ i +"].TargetVoucherId");

				photoInvoiceResponse_item.Add(itemItem);
			}
			photoInvoiceResponse.Item = photoInvoiceResponse_item;
        
			return photoInvoiceResponse;
        }
    }
}
