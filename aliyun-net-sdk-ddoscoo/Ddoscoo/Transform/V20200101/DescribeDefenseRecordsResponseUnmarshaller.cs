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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeDefenseRecordsResponseUnmarshaller
    {
        public static DescribeDefenseRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDefenseRecordsResponse describeDefenseRecordsResponse = new DescribeDefenseRecordsResponse();

			describeDefenseRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeDefenseRecordsResponse.RequestId = _ctx.StringValue("DescribeDefenseRecords.RequestId");
			describeDefenseRecordsResponse.TotalCount = _ctx.LongValue("DescribeDefenseRecords.TotalCount");

			List<DescribeDefenseRecordsResponse.DescribeDefenseRecords_DefenseRecord> describeDefenseRecordsResponse_defenseRecords = new List<DescribeDefenseRecordsResponse.DescribeDefenseRecords_DefenseRecord>();
			for (int i = 0; i < _ctx.Length("DescribeDefenseRecords.DefenseRecords.Length"); i++) {
				DescribeDefenseRecordsResponse.DescribeDefenseRecords_DefenseRecord defenseRecord = new DescribeDefenseRecordsResponse.DescribeDefenseRecords_DefenseRecord();
				defenseRecord.StartTime = _ctx.LongValue("DescribeDefenseRecords.DefenseRecords["+ i +"].StartTime");
				defenseRecord.EndTime = _ctx.LongValue("DescribeDefenseRecords.DefenseRecords["+ i +"].EndTime");
				defenseRecord.InstanceId = _ctx.StringValue("DescribeDefenseRecords.DefenseRecords["+ i +"].InstanceId");
				defenseRecord.Status = _ctx.IntegerValue("DescribeDefenseRecords.DefenseRecords["+ i +"].Status");
				defenseRecord.AttackPeak = _ctx.LongValue("DescribeDefenseRecords.DefenseRecords["+ i +"].AttackPeak");
				defenseRecord.EventCount = _ctx.IntegerValue("DescribeDefenseRecords.DefenseRecords["+ i +"].EventCount");

				describeDefenseRecordsResponse_defenseRecords.Add(defenseRecord);
			}
			describeDefenseRecordsResponse.DefenseRecords = describeDefenseRecordsResponse_defenseRecords;
        
			return describeDefenseRecordsResponse;
        }
    }
}
