﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class BrekelMongo
    {
        public ObjectId _id { get; set; }
        public double timestamp { get; set; }
        public double isTracked { get; set; }
        public double isEngaged { get; set; }
        public double isRestricted { get; set; }
        public double isClippedLeft { get; set; }
        public double isClippedRight { get; set; }
        public double isClippedTop { get; set; }
        public double isClippedBottom { get; set; }
        public double leanX { get; set; }
        public double leanY { get; set; }
        public double lean_confidence { get; set; }
        public double hand_L_state { get; set; }
        public double hand_R_state { get; set; }
        public double hand_L_state_confidence { get; set; }
        public double hand_R_state_confidence { get; set; }
        public double face_isTracked { get; set; }
        public double face_isHappy { get; set; }
        public double face_isEngaged { get; set; }
        public double face_isWearingGlasses { get; set; }
        public double face_isEyeLeftClosed { get; set; }
        public double face_isEyeRightClosed { get; set; }
        public double face_isMouthOpen { get; set; }
        public double face_isMouthMoved { get; set; }
        public double face_isLookingAway { get; set; }
        public double waist_conf { get; set; }
        public double waist_tx { get; set; }
        public double waist_ty { get; set; }
        public double waist_tz { get; set; }
        public double waist_rx { get; set; }
        public double waist_ry { get; set; }
        public double waist_rz { get; set; }
        public double spine_conf { get; set; }
        public double spine_tx { get; set; }
        public double spine_ty { get; set; }
        public double spine_tz { get; set; }
        public double spine_rx { get; set; }
        public double spine_ry { get; set; }
        public double spine_rz { get; set; }
        public double chest_conf { get; set; }
        public double chest_tx { get; set; }
        public double chest_ty { get; set; }
        public double chest_tz { get; set; }
        public double chest_rx { get; set; }
        public double chest_ry { get; set; }
        public double chest_rz { get; set; }
        public double neck_conf { get; set; }
        public double neck_tx { get; set; }
        public double neck_ty { get; set; }
        public double neck_tz { get; set; }
        public double neck_rx { get; set; }
        public double neck_ry { get; set; }
        public double neck_rz { get; set; }
        public double head_conf { get; set; }
        public double head_tx { get; set; }
        public double head_ty { get; set; }
        public double head_tz { get; set; }
        public double head_rx { get; set; }
        public double head_ry { get; set; }
        public double head_rz { get; set; }
        public double head_tip_conf { get; set; }
        public double head_tip_tx { get; set; }
        public double head_tip_ty { get; set; }
        public double head_tip_tz { get; set; }
        public double head_tip_rx { get; set; }
        public double head_tip_ry { get; set; }
        public double head_tip_rz { get; set; }
        public double upperLeg_L_conf { get; set; }
        public double upperLeg_L_tx { get; set; }
        public double upperLeg_L_ty { get; set; }
        public double upperLeg_L_tz { get; set; }
        public double upperLeg_L_rx { get; set; }
        public double upperLeg_L_ry { get; set; }
        public double upperLeg_L_rz { get; set; }
        public double lowerLeg_L_conf { get; set; }
        public double lowerLeg_L_tx { get; set; }
        public double lowerLeg_L_ty { get; set; }
        public double lowerLeg_L_tz { get; set; }
        public double lowerLeg_L_rx { get; set; }
        public double lowerLeg_L_ry { get; set; }
        public double lowerLeg_L_rz { get; set; }

        public double foot_L_conf { get; set; }
        public double foot_L_tx { get; set; }
        public double foot_L_ty { get; set; }
        public double foot_L_tz { get; set; }
        public double foot_L_rx { get; set; }
        public double foot_L_ry { get; set; }
        public double foot_L_rz { get; set; }
        public double toes_L_conf { get; set; }
        public double toes_L_tx { get; set; }
        public double toes_L_ty { get; set; }
        public double toes_L_tz { get; set; }
        public double toes_L_rx { get; set; }
        public double toes_L_ry { get; set; }
        public double toes_L_rz { get; set; }
        public double upperLeg_R_conf { get; set; }
        public double upperLeg_R_tx { get; set; }
        public double upperLeg_R_ty { get; set; }
        public double upperLeg_R_tz { get; set; }
        public double upperLeg_R_rx { get; set; }
        public double upperLeg_R_ry { get; set; }
        public double upperLeg_R_rz { get; set; }
        public double lowerLeg_R_conf { get; set; }
        public double lowerLeg_R_tx { get; set; }
        public double lowerLeg_R_ty { get; set; }
        public double lowerLeg_R_tz { get; set; }
        public double lowerLeg_R_rx { get; set; }
        public double lowerLeg_R_ry { get; set; }
        public double lowerLeg_R_rz { get; set; }
        public double foot_R_conf { get; set; }
        public double foot_R_tx { get; set; }
        public double foot_R_ty { get; set; }
        public double foot_R_tz { get; set; }
        public double foot_R_rx { get; set; }
        public double foot_R_ry { get; set; }
        public double foot_R_rz { get; set; }
        public double toes_R_conf { get; set; }
        public double toes_R_tx { get; set; }
        public double toes_R_ty { get; set; }
        public double toes_R_tz { get; set; }
        public double toes_R_rx { get; set; }
        public double toes_R_ry { get; set; }
        public double toes_R_rz { get; set; }
        public double collar_L_conf { get; set; }
        public double collar_L_tx { get; set; }
        public double collar_L_ty { get; set; }
        public double collar_L_tz { get; set; }
        public double collar_L_rx { get; set; }
        public double collar_L_ry { get; set; }
        public double collar_L_rz { get; set; }
        public double upperArm_L_conf { get; set; }
        public double upperArm_L_tx { get; set; }
        public double upperArm_L_ty { get; set; }
        public double upperArm_L_tz { get; set; }
        public double upperArm_L_rx { get; set; }
        public double upperArm_L_ry { get; set; }
        public double upperArm_L_rz { get; set; }
        public double foreArm_L_conf { get; set; }
        public double foreArm_L_tx { get; set; }
        public double foreArm_L_ty { get; set; }
        public double foreArm_L_tz { get; set; }
        public double foreArm_L_rx { get; set; }
        public double foreArm_L_ry { get; set; }
        public double foreArm_L_rz { get; set; }
        public double hand_L_conf { get; set; }
        public double hand_L_tx { get; set; }
        public double hand_L_ty { get; set; }
        public double hand_L_tz { get; set; }
        public double hand_L_rx { get; set; }
        public double hand_L_ry { get; set; }
        public double hand_L_rz { get; set; }
        public double collar_R_conf { get; set; }
        public double collar_R_tx { get; set; }
        public double collar_R_ty { get; set; }
        public double collar_R_tz { get; set; }
        public double collar_R_rx { get; set; }
        public double collar_R_ry { get; set; }
        public double collar_R_rz { get; set; }
        public double upperArm_R_conf { get; set; }
        public double upperArm_R_tx { get; set; }
        public double upperArm_R_ty { get; set; }
        public double upperArm_R_tz { get; set; }
        public double upperArm_R_rx { get; set; }
        public double upperArm_R_ry { get; set; }
        public double upperArm_R_rz { get; set; }
        public double foreArm_R_conf { get; set; }
        public double foreArm_R_tx { get; set; }
        public double foreArm_R_ty { get; set; }
        public double foreArm_R_tz { get; set; }
        public double foreArm_R_rx { get; set; }
        public double foreArm_R_ry { get; set; }
        public double foreArm_R_rz { get; set; }
        public double hand_R_conf { get; set; }
        public double hand_R_tx { get; set; }
        public double hand_R_ty { get; set; }
        public double hand_R_tz { get; set; }
        public double hand_R_rx { get; set; }
        public double hand_R_ry { get; set; }
        public double hand_R_rz { get; set; }
        public double thumb_L_0_conf { get; set; }
        public double thumb_L_0_tx { get; set; }
        public double thumb_L_0_ty { get; set; }
        public double thumb_L_0_tz { get; set; }
        public double thumb_L_0_rx { get; set; }
        public double thumb_L_0_ry { get; set; }
        public double thumb_L_0_rz { get; set; }
        public double thumb_L_1_conf { get; set; }
        public double thumb_L_1_tx { get; set; }
        public double thumb_L_1_ty { get; set; }
        public double thumb_L_1_tz { get; set; }
        public double thumb_L_1_rx { get; set; }
        public double thumb_L_1_ry { get; set; }
        public double thumb_L_1_rz { get; set; }
        public double thumb_L_2_conf { get; set; }
        public double thumb_L_2_tx { get; set; }
        public double thumb_L_2_ty { get; set; }
        public double thumb_L_2_tz { get; set; }
        public double thumb_L_2_rx { get; set; }
        public double thumb_L_2_ry { get; set; }
        public double thumb_L_2_rz { get; set; }
        public double thumb_L_3_conf { get; set; }
        public double thumb_L_3_tx { get; set; }
        public double thumb_L_3_ty { get; set; }
        public double thumb_L_3_tz { get; set; }
        public double thumb_L_3_rx { get; set; }
        public double thumb_L_3_ry { get; set; }
        public double thumb_L_3_rz { get; set; }
        public double index_L_0_conf { get; set; }
        public double index_L_0_tx { get; set; }
        public double index_L_0_ty { get; set; }
        public double index_L_0_tz { get; set; }
        public double index_L_0_rx { get; set; }
        public double index_L_0_ry { get; set; }
        public double index_L_0_rz { get; set; }
        public double index_L_1_conf { get; set; }
        public double index_L_1_tx { get; set; }
        public double index_L_1_ty { get; set; }
        public double index_L_1_tz { get; set; }
        public double index_L_1_rx { get; set; }
        public double index_L_1_ry { get; set; }
        public double index_L_1_rz { get; set; }
        public double index_L_2_conf { get; set; }
        public double index_L_2_tx { get; set; }
        public double index_L_2_ty { get; set; }
        public double index_L_2_tz { get; set; }
        public double index_L_2_rx { get; set; }
        public double index_L_2_ry { get; set; }
        public double index_L_2_rz { get; set; }
        public double index_L_3_conf { get; set; }
        public double index_L_3_tx { get; set; }
        public double index_L_3_ty { get; set; }
        public double index_L_3_tz { get; set; }
        public double index_L_3_rx { get; set; }
        public double index_L_3_ry { get; set; }
        public double index_L_3_rz { get; set; }
        public double middle_L_0_conf { get; set; }
        public double middle_L_0_tx { get; set; }
        public double middle_L_0_ty { get; set; }
        public double middle_L_0_tz { get; set; }
        public double middle_L_0_rx { get; set; }
        public double middle_L_0_ry { get; set; }
        public double middle_L_0_rz { get; set; }
        public double middle_L_1_conf { get; set; }
        public double middle_L_1_tx { get; set; }
        public double middle_L_1_ty { get; set; }
        public double middle_L_1_tz { get; set; }
        public double middle_L_1_rx { get; set; }
        public double middle_L_1_ry { get; set; }
        public double middle_L_1_rz { get; set; }
        public double middle_L_2_conf { get; set; }
        public double middle_L_2_tx { get; set; }
        public double middle_L_2_ty { get; set; }
        public double middle_L_2_tz { get; set; }
        public double middle_L_2_rx { get; set; }
        public double middle_L_2_ry { get; set; }
        public double middle_L_2_rz { get; set; }
        public double middle_L_3_conf { get; set; }
        public double middle_L_3_tx { get; set; }
        public double middle_L_3_ty { get; set; }
        public double middle_L_3_tz { get; set; }
        public double middle_L_3_rx { get; set; }
        public double middle_L_3_ry { get; set; }
        public double middle_L_3_rz { get; set; }
        public double ring_L_0_conf { get; set; }
        public double ring_L_0_tx { get; set; }
        public double ring_L_0_ty { get; set; }
        public double ring_L_0_tz { get; set; }
        public double ring_L_0_rx { get; set; }
        public double ring_L_0_ry { get; set; }
        public double ring_L_0_rz { get; set; }
        public double ring_L_1_conf { get; set; }
        public double ring_L_1_tx { get; set; }
        public double ring_L_1_ty { get; set; }
        public double ring_L_1_tz { get; set; }
        public double ring_L_1_rx { get; set; }
        public double ring_L_1_ry { get; set; }
        public double ring_L_1_rz { get; set; }
        public double ring_L_2_conf { get; set; }
        public double ring_L_2_tx { get; set; }
        public double ring_L_2_ty { get; set; }
        public double ring_L_2_tz { get; set; }
        public double ring_L_2_rx { get; set; }
        public double ring_L_2_ry { get; set; }
        public double ring_L_2_rz { get; set; }
        public double ring_L_3_conf { get; set; }
        public double ring_L_3_tx { get; set; }
        public double ring_L_3_ty { get; set; }
        public double ring_L_3_tz { get; set; }
        public double ring_L_3_rx { get; set; }
        public double ring_L_3_ry { get; set; }
        public double ring_L_3_rz { get; set; }
        public double pinky_L_0_conf { get; set; }
        public double pinky_L_0_tx { get; set; }
        public double pinky_L_0_ty { get; set; }
        public double pinky_L_0_tz { get; set; }
        public double pinky_L_0_rx { get; set; }
        public double pinky_L_0_ry { get; set; }
        public double pinky_L_0_rz { get; set; }
        public double pinky_L_1_conf { get; set; }
        public double pinky_L_1_tx { get; set; }
        public double pinky_L_1_ty { get; set; }
        public double pinky_L_1_tz { get; set; }
        public double pinky_L_1_rx { get; set; }
        public double pinky_L_1_ry { get; set; }
        public double pinky_L_1_rz { get; set; }
        public double pinky_L_2_conf { get; set; }
        public double pinky_L_2_tx { get; set; }
        public double pinky_L_2_ty { get; set; }
        public double pinky_L_2_tz { get; set; }
        public double pinky_L_2_rx { get; set; }
        public double pinky_L_2_ry { get; set; }
        public double pinky_L_2_rz { get; set; }
        public double pinky_L_3_conf { get; set; }
        public double pinky_L_3_tx { get; set; }
        public double pinky_L_3_ty { get; set; }
        public double pinky_L_3_tz { get; set; }
        public double pinky_L_3_rx { get; set; }
        public double pinky_L_3_ry { get; set; }
        public double pinky_L_3_rz { get; set; }
        public double thumb_R_0_conf { get; set; }
        public double thumb_R_0_tx { get; set; }
        public double thumb_R_0_ty { get; set; }
        public double thumb_R_0_tz { get; set; }
        public double thumb_R_0_rx { get; set; }
        public double thumb_R_0_ry { get; set; }
        public double thumb_R_0_rz { get; set; }
        public double thumb_R_1_conf { get; set; }
        public double thumb_R_1_tx { get; set; }
        public double thumb_R_1_ty { get; set; }
        public double thumb_R_1_tz { get; set; }
        public double thumb_R_1_rx { get; set; }
        public double thumb_R_1_ry { get; set; }
        public double thumb_R_1_rz { get; set; }
        public double thumb_R_2_conf { get; set; }
        public double thumb_R_2_tx { get; set; }
        public double thumb_R_2_ty { get; set; }
        public double thumb_R_2_tz { get; set; }
        public double thumb_R_2_rx { get; set; }
        public double thumb_R_2_ry { get; set; }
        public double thumb_R_2_rz { get; set; }
        public double thumb_R_3_conf { get; set; }
        public double thumb_R_3_tx { get; set; }
        public double thumb_R_3_ty { get; set; }
        public double thumb_R_3_tz { get; set; }
        public double thumb_R_3_rx { get; set; }
        public double thumb_R_3_ry { get; set; }
        public double thumb_R_3_rz { get; set; }
        public double index_R_0_conf { get; set; }
        public double index_R_0_tx { get; set; }
        public double index_R_0_ty { get; set; }
        public double index_R_0_tz { get; set; }
        public double index_R_0_rx { get; set; }
        public double index_R_0_ry { get; set; }
        public double index_R_0_rz { get; set; }
        public double index_R_1_conf { get; set; }
        public double index_R_1_tx { get; set; }
        public double index_R_1_ty { get; set; }
        public double index_R_1_tz { get; set; }
        public double index_R_1_rx { get; set; }
        public double index_R_1_ry { get; set; }
        public double index_R_1_rz { get; set; }
        public double index_R_2_conf { get; set; }
        public double index_R_2_tx { get; set; }
        public double index_R_2_ty { get; set; }
        public double index_R_2_tz { get; set; }
        public double index_R_2_rx { get; set; }
        public double index_R_2_ry { get; set; }
        public double index_R_2_rz { get; set; }
        public double index_R_3_conf { get; set; }
        public double index_R_3_tx { get; set; }
        public double index_R_3_ty { get; set; }
        public double index_R_3_tz { get; set; }
        public double index_R_3_rx { get; set; }
        public double index_R_3_ry { get; set; }
        public double index_R_3_rz { get; set; }
        public double middle_R_0_conf { get; set; }
        public double middle_R_0_tx { get; set; }
        public double middle_R_0_ty { get; set; }
        public double middle_R_0_tz { get; set; }
        public double middle_R_0_rx { get; set; }
        public double middle_R_0_ry { get; set; }
        public double middle_R_0_rz { get; set; }
        public double middle_R_1_conf { get; set; }
        public double middle_R_1_tx { get; set; }
        public double middle_R_1_ty { get; set; }
        public double middle_R_1_tz { get; set; }
        public double middle_R_1_rx { get; set; }
        public double middle_R_1_ry { get; set; }
        public double middle_R_1_rz { get; set; }
        public double middle_R_2_conf { get; set; }
        public double middle_R_2_tx { get; set; }
        public double middle_R_2_ty { get; set; }
        public double middle_R_2_tz { get; set; }
        public double middle_R_2_rx { get; set; }
        public double middle_R_2_ry { get; set; }
        public double middle_R_2_rz { get; set; }
        public double middle_R_3_conf { get; set; }
        public double middle_R_3_tx { get; set; }
        public double middle_R_3_ty { get; set; }
        public double middle_R_3_tz { get; set; }
        public double middle_R_3_rx { get; set; }
        public double middle_R_3_ry { get; set; }
        public double middle_R_3_rz { get; set; }
        public double ring_R_0_conf { get; set; }
        public double ring_R_0_tx { get; set; }
        public double ring_R_0_ty { get; set; }
        public double ring_R_0_tz { get; set; }
        public double ring_R_0_rx { get; set; }
        public double ring_R_0_ry { get; set; }
        public double ring_R_0_rz { get; set; }
        public double ring_R_1_conf { get; set; }
        public double ring_R_1_tx { get; set; }
        public double ring_R_1_ty { get; set; }
        public double ring_R_1_tz { get; set; }
        public double ring_R_1_rx { get; set; }
        public double ring_R_1_ry { get; set; }
        public double ring_R_1_rz { get; set; }
        public double ring_R_2_conf { get; set; }
        public double ring_R_2_tx { get; set; }
        public double ring_R_2_ty { get; set; }
        public double ring_R_2_tz { get; set; }
        public double ring_R_2_rx { get; set; }
        public double ring_R_2_ry { get; set; }
        public double ring_R_2_rz { get; set; }
        public double ring_R_3_conf { get; set; }
        public double ring_R_3_tx { get; set; }
        public double ring_R_3_ty { get; set; }
        public double ring_R_3_tz { get; set; }
        public double ring_R_3_rx { get; set; }
        public double ring_R_3_ry { get; set; }
        public double ring_R_3_rz { get; set; }
        public double pinky_R_0_conf { get; set; }
        public double pinky_R_0_tx { get; set; }
        public double pinky_R_0_ty { get; set; }
        public double pinky_R_0_tz { get; set; }
        public double pinky_R_0_rx { get; set; }
        public double pinky_R_0_ry { get; set; }
        public double pinky_R_0_rz { get; set; }
        public double pinky_R_1_conf { get; set; }
        public double pinky_R_1_tx { get; set; }
        public double pinky_R_1_ty { get; set; }
        public double pinky_R_1_tz { get; set; }
        public double pinky_R_1_rx { get; set; }
        public double pinky_R_1_ry { get; set; }
        public double pinky_R_1_rz { get; set; }
        public double pinky_R_2_conf { get; set; }
        public double pinky_R_2_tx { get; set; }
        public double pinky_R_2_ty { get; set; }
        public double pinky_R_2_tz { get; set; }
        public double pinky_R_2_rx { get; set; }
        public double pinky_R_2_ry { get; set; }
        public double pinky_R_2_rz { get; set; }
        public double pinky_R_3_conf { get; set; }
        public double pinky_R_3_tx { get; set; }
        public double pinky_R_3_ty { get; set; }
        public double pinky_R_3_tz { get; set; }
        public double pinky_R_3_rx { get; set; }
        public double pinky_R_3_ry { get; set; }
        public double pinky_R_3_rz { get; set; }
    }
}