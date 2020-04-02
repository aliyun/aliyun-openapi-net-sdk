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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class QueryMovieTicketsResponseUnmarshaller
    {
        public static QueryMovieTicketsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMovieTicketsResponse queryMovieTicketsResponse = new QueryMovieTicketsResponse();

			queryMovieTicketsResponse.HttpResponse = context.HttpResponse;
			queryMovieTicketsResponse.RequestId = context.StringValue("QueryMovieTickets.RequestId");
			queryMovieTicketsResponse.LogsId = context.StringValue("QueryMovieTickets.LogsId");
			queryMovieTicketsResponse.SubCode = context.StringValue("QueryMovieTickets.SubCode");
			queryMovieTicketsResponse.SubMessage = context.StringValue("QueryMovieTickets.SubMessage");
			queryMovieTicketsResponse.Code = context.StringValue("QueryMovieTickets.Code");
			queryMovieTicketsResponse.Message = context.StringValue("QueryMovieTickets.Message");
			queryMovieTicketsResponse.Success = context.BooleanValue("QueryMovieTickets.Success");

			QueryMovieTicketsResponse.QueryMovieTickets_MovieTicket movieTicket = new QueryMovieTicketsResponse.QueryMovieTickets_MovieTicket();
			movieTicket.Status = context.StringValue("QueryMovieTickets.MovieTicket.Status");
			movieTicket.ReturnMessage = context.StringValue("QueryMovieTickets.MovieTicket.ReturnMessage");
			movieTicket.TbOrderId = context.StringValue("QueryMovieTickets.MovieTicket.TbOrderId");
			movieTicket.TicketContents = context.StringValue("QueryMovieTickets.MovieTicket.TicketContents");
			queryMovieTicketsResponse.MovieTicket = movieTicket;
        
			return queryMovieTicketsResponse;
        }
    }
}
