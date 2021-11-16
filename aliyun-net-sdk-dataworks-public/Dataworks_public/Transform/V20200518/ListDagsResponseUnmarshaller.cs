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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListDagsResponseUnmarshaller
    {
        public static ListDagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDagsResponse listDagsResponse = new ListDagsResponse();

			listDagsResponse.HttpResponse = _ctx.HttpResponse;
			listDagsResponse.HttpStatusCode = _ctx.IntegerValue("ListDags.HttpStatusCode");
			listDagsResponse.RequestId = _ctx.StringValue("ListDags.RequestId");
			listDagsResponse.ErrorMessage = _ctx.StringValue("ListDags.ErrorMessage");
			listDagsResponse.ErrorCode = _ctx.StringValue("ListDags.ErrorCode");
			listDagsResponse.Success = _ctx.BooleanValue("ListDags.Success");

			ListDagsResponse.ListDags_Data data = new ListDagsResponse.ListDags_Data();

			List<ListDagsResponse.ListDags_Data.ListDags_Dag> data_dags = new List<ListDagsResponse.ListDags_Data.ListDags_Dag>();
			for (int i = 0; i < _ctx.Length("ListDags.Data.Dags.Length"); i++) {
				ListDagsResponse.ListDags_Data.ListDags_Dag dag = new ListDagsResponse.ListDags_Data.ListDags_Dag();
				dag.Type = _ctx.StringValue("ListDags.Data.Dags["+ i +"].Type");
				dag.Status = _ctx.StringValue("ListDags.Data.Dags["+ i +"].Status");
				dag.FinishTime = _ctx.LongValue("ListDags.Data.Dags["+ i +"].FinishTime");
				dag.CreateTime = _ctx.LongValue("ListDags.Data.Dags["+ i +"].CreateTime");
				dag.ProjectId = _ctx.LongValue("ListDags.Data.Dags["+ i +"].ProjectId");
				dag.DagId = _ctx.LongValue("ListDags.Data.Dags["+ i +"].DagId");
				dag.Gmtdate = _ctx.LongValue("ListDags.Data.Dags["+ i +"].Gmtdate");
				dag.StartTime = _ctx.LongValue("ListDags.Data.Dags["+ i +"].StartTime");
				dag.CreateUser = _ctx.StringValue("ListDags.Data.Dags["+ i +"].CreateUser");
				dag.Bizdate = _ctx.LongValue("ListDags.Data.Dags["+ i +"].Bizdate");
				dag.Name = _ctx.StringValue("ListDags.Data.Dags["+ i +"].Name");
				dag.ModifyTime = _ctx.LongValue("ListDags.Data.Dags["+ i +"].ModifyTime");
				dag.OpSeq = _ctx.LongValue("ListDags.Data.Dags["+ i +"].OpSeq");

				data_dags.Add(dag);
			}
			data.Dags = data_dags;
			listDagsResponse.Data = data;
        
			return listDagsResponse;
        }
    }
}
