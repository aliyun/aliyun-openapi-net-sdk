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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class GetPortrayalResponseUnmarshaller
    {
        public static GetPortrayalResponse Unmarshall(UnmarshallerContext context)
        {
			GetPortrayalResponse getPortrayalResponse = new GetPortrayalResponse();

			getPortrayalResponse.HttpResponse = context.HttpResponse;
			getPortrayalResponse.FemalePercent = context.FloatValue("GetPortrayal.FemalePercent");
			getPortrayalResponse.Mcount = context.LongValue("GetPortrayal.Mcount");
			getPortrayalResponse.Mcount1120 = context.LongValue("GetPortrayal.Mcount1120");
			getPortrayalResponse.Newcount = context.LongValue("GetPortrayal.Newcount");
			getPortrayalResponse.Agecount3140Percent = context.FloatValue("GetPortrayal.Agecount3140Percent");
			getPortrayalResponse.Agecount4150Percent = context.FloatValue("GetPortrayal.Agecount4150Percent");
			getPortrayalResponse.Agecount010Percent = context.FloatValue("GetPortrayal.Agecount010Percent");
			getPortrayalResponse.Fcount5160 = context.LongValue("GetPortrayal.Fcount5160");
			getPortrayalResponse.Mcount010 = context.LongValue("GetPortrayal.Mcount010");
			getPortrayalResponse.Mcountgt60 = context.LongValue("GetPortrayal.Mcountgt60");
			getPortrayalResponse.Agecount1120Percent = context.FloatValue("GetPortrayal.Agecount1120Percent");
			getPortrayalResponse.Fcountgt60 = context.LongValue("GetPortrayal.Fcountgt60");
			getPortrayalResponse.Fcount4150 = context.LongValue("GetPortrayal.Fcount4150");
			getPortrayalResponse.Oldcount = context.LongValue("GetPortrayal.Oldcount");
			getPortrayalResponse.Fcount3140 = context.LongValue("GetPortrayal.Fcount3140");
			getPortrayalResponse.Fcount2130 = context.LongValue("GetPortrayal.Fcount2130");
			getPortrayalResponse.Agecountgt60Percent = context.FloatValue("GetPortrayal.Agecountgt60Percent");
			getPortrayalResponse.Fcount1120 = context.LongValue("GetPortrayal.Fcount1120");
			getPortrayalResponse.OldcountPercent = context.FloatValue("GetPortrayal.OldcountPercent");
			getPortrayalResponse.Mcount4150 = context.LongValue("GetPortrayal.Mcount4150");
			getPortrayalResponse.Fcount = context.LongValue("GetPortrayal.Fcount");
			getPortrayalResponse.NewcountPercent = context.FloatValue("GetPortrayal.NewcountPercent");
			getPortrayalResponse.Mcount2130 = context.LongValue("GetPortrayal.Mcount2130");
			getPortrayalResponse.Mcount3140 = context.LongValue("GetPortrayal.Mcount3140");
			getPortrayalResponse.Agecount5160Percent = context.FloatValue("GetPortrayal.Agecount5160Percent");
			getPortrayalResponse.Agecount2130Percent = context.FloatValue("GetPortrayal.Agecount2130Percent");
			getPortrayalResponse.Fcount010 = context.LongValue("GetPortrayal.Fcount010");
			getPortrayalResponse.Mcount5160 = context.LongValue("GetPortrayal.Mcount5160");
			getPortrayalResponse.MalePercent = context.FloatValue("GetPortrayal.MalePercent");
        
			return getPortrayalResponse;
        }
    }
}
