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
using Aliyun.Acs.ocr.Model.V20191230;

namespace Aliyun.Acs.ocr.Transform.V20191230
{
    public class RecognizeTrainTicketResponseUnmarshaller
    {
        public static RecognizeTrainTicketResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeTrainTicketResponse recognizeTrainTicketResponse = new RecognizeTrainTicketResponse();

			recognizeTrainTicketResponse.HttpResponse = _ctx.HttpResponse;
			recognizeTrainTicketResponse.RequestId = _ctx.StringValue("RecognizeTrainTicket.RequestId");

			RecognizeTrainTicketResponse.RecognizeTrainTicket_Data data = new RecognizeTrainTicketResponse.RecognizeTrainTicket_Data();
			data.Date = _ctx.StringValue("RecognizeTrainTicket.Data.Date");
			data.Destination = _ctx.StringValue("RecognizeTrainTicket.Data.Destination");
			data.Level = _ctx.StringValue("RecognizeTrainTicket.Data.Level");
			data.Number = _ctx.StringValue("RecognizeTrainTicket.Data.Number");
			data.Name = _ctx.StringValue("RecognizeTrainTicket.Data.Name");
			data.DepartureStation = _ctx.StringValue("RecognizeTrainTicket.Data.DepartureStation");
			data.Seat = _ctx.StringValue("RecognizeTrainTicket.Data.Seat");
			data.Price = _ctx.FloatValue("RecognizeTrainTicket.Data.Price");
			recognizeTrainTicketResponse.Data = data;
        
			return recognizeTrainTicketResponse;
        }
    }
}
