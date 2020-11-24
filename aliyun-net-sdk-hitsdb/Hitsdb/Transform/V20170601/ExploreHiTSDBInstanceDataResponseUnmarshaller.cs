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
using Aliyun.Acs.hitsdb.Model.V20170601;

namespace Aliyun.Acs.hitsdb.Transform.V20170601
{
    public class ExploreHiTSDBInstanceDataResponseUnmarshaller
    {
        public static ExploreHiTSDBInstanceDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExploreHiTSDBInstanceDataResponse exploreHiTSDBInstanceDataResponse = new ExploreHiTSDBInstanceDataResponse();

			exploreHiTSDBInstanceDataResponse.HttpResponse = _ctx.HttpResponse;
			exploreHiTSDBInstanceDataResponse.RequestId = _ctx.StringValue("ExploreHiTSDBInstanceData.RequestId");
			exploreHiTSDBInstanceDataResponse.Start = _ctx.StringValue("ExploreHiTSDBInstanceData.Start");
			exploreHiTSDBInstanceDataResponse.End = _ctx.StringValue("ExploreHiTSDBInstanceData.End");
			exploreHiTSDBInstanceDataResponse.Metric = _ctx.StringValue("ExploreHiTSDBInstanceData.Metric");

			List<ExploreHiTSDBInstanceDataResponse.ExploreHiTSDBInstanceData_TimeLine> exploreHiTSDBInstanceDataResponse_timeLines = new List<ExploreHiTSDBInstanceDataResponse.ExploreHiTSDBInstanceData_TimeLine>();
			for (int i = 0; i < _ctx.Length("ExploreHiTSDBInstanceData.TimeLines.Length"); i++) {
				ExploreHiTSDBInstanceDataResponse.ExploreHiTSDBInstanceData_TimeLine timeLine = new ExploreHiTSDBInstanceDataResponse.ExploreHiTSDBInstanceData_TimeLine();

				List<ExploreHiTSDBInstanceDataResponse.ExploreHiTSDBInstanceData_TimeLine.ExploreHiTSDBInstanceData_Tag> timeLine_tags = new List<ExploreHiTSDBInstanceDataResponse.ExploreHiTSDBInstanceData_TimeLine.ExploreHiTSDBInstanceData_Tag>();
				for (int j = 0; j < _ctx.Length("ExploreHiTSDBInstanceData.TimeLines["+ i +"].Tags.Length"); j++) {
					ExploreHiTSDBInstanceDataResponse.ExploreHiTSDBInstanceData_TimeLine.ExploreHiTSDBInstanceData_Tag tag = new ExploreHiTSDBInstanceDataResponse.ExploreHiTSDBInstanceData_TimeLine.ExploreHiTSDBInstanceData_Tag();
					tag.TagKey = _ctx.StringValue("ExploreHiTSDBInstanceData.TimeLines["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("ExploreHiTSDBInstanceData.TimeLines["+ i +"].Tags["+ j +"].TagValue");

					timeLine_tags.Add(tag);
				}
				timeLine.Tags = timeLine_tags;

				List<ExploreHiTSDBInstanceDataResponse.ExploreHiTSDBInstanceData_TimeLine.ExploreHiTSDBInstanceData_Point> timeLine_series = new List<ExploreHiTSDBInstanceDataResponse.ExploreHiTSDBInstanceData_TimeLine.ExploreHiTSDBInstanceData_Point>();
				for (int j = 0; j < _ctx.Length("ExploreHiTSDBInstanceData.TimeLines["+ i +"].Series.Length"); j++) {
					ExploreHiTSDBInstanceDataResponse.ExploreHiTSDBInstanceData_TimeLine.ExploreHiTSDBInstanceData_Point point = new ExploreHiTSDBInstanceDataResponse.ExploreHiTSDBInstanceData_TimeLine.ExploreHiTSDBInstanceData_Point();
					point.Timestamp = _ctx.StringValue("ExploreHiTSDBInstanceData.TimeLines["+ i +"].Series["+ j +"].Timestamp");
					point._Value = _ctx.FloatValue("ExploreHiTSDBInstanceData.TimeLines["+ i +"].Series["+ j +"].Value");

					timeLine_series.Add(point);
				}
				timeLine.Series = timeLine_series;

				exploreHiTSDBInstanceDataResponse_timeLines.Add(timeLine);
			}
			exploreHiTSDBInstanceDataResponse.TimeLines = exploreHiTSDBInstanceDataResponse_timeLines;
        
			return exploreHiTSDBInstanceDataResponse;
        }
    }
}
